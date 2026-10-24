using UnityEngine;

public class MobileLook : MonoBehaviour
{
    [SerializeField] private Transform playerBody;
    [SerializeField] private float sensitivity = 0.12f;
    [SerializeField] private float minPitch = -75f;
    [SerializeField] private float maxPitch = 75f;
    private float pitch;

    // Call from a right-side touch-drag area; pass the drag delta in pixels.
    public void LookDelta(Vector2 delta)
    {
        float yaw = delta.x * sensitivity;
        pitch = Mathf.Clamp(pitch - delta.y * sensitivity, minPitch, maxPitch);
        transform.localRotation = Quaternion.Euler(pitch, 0f, 0f);
        if (playerBody) playerBody.Rotate(Vector3.up * yaw);
    }

    public void SetSensitivity(float value) => sensitivity = Mathf.Clamp(value, 0.02f, 0.5f);
}
