using UnityEngine;

[RequireComponent(typeof(CharacterController))]
public class PlayerMotor : MonoBehaviour
{
    [SerializeField] private Transform cameraRoot;
    [SerializeField] private float moveSpeed = 5f;
    [SerializeField] private float gravity = -20f;
    private CharacterController controller;
    private Vector2 moveInput;
    private float verticalVelocity;

    private void Awake() => controller = GetComponent<CharacterController>();

    // Connect a mobile joystick's Vector2 output to this method.
    public void SetMoveInput(Vector2 input) => moveInput = Vector2.ClampMagnitude(input, 1f);

    private void Update()
    {
        Vector3 forward = cameraRoot ? cameraRoot.forward : transform.forward;
        Vector3 right = cameraRoot ? cameraRoot.right : transform.right;
        forward.y = 0f; right.y = 0f;
        forward.Normalize(); right.Normalize();

        Vector3 move = (forward * moveInput.y + right * moveInput.x) * moveSpeed;
        if (controller.isGrounded && verticalVelocity < 0f) verticalVelocity = -2f;
        verticalVelocity += gravity * Time.deltaTime;
        move.y = verticalVelocity;
        controller.Move(move * Time.deltaTime);
    }
}
