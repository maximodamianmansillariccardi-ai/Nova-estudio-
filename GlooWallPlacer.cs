using UnityEngine;

public class GlooWallPlacer : MonoBehaviour
{
    [SerializeField] private GameObject wallPrefab;
    [SerializeField] private Transform placementOrigin;
    [SerializeField] private float placeDistance = 3f;
    [SerializeField] private float cooldown = 8f;
    [SerializeField] private int startingCharges = 3;
    private float readyAt;
    private int charges;

    private void Awake() => charges = startingCharges;

    // Connect to the gloo-wall button. Prefab should have collider and visuals.
    public void TryPlaceWall()
    {
        if (!wallPrefab || !placementOrigin || Time.time < readyAt || charges <= 0) return;
        Vector3 position = placementOrigin.position + placementOrigin.forward * placeDistance;
        position.y = placementOrigin.position.y;
        Quaternion rotation = Quaternion.LookRotation(placementOrigin.forward, Vector3.up);
        rotation = Quaternion.Euler(0f, rotation.eulerAngles.y, 0f);
        Instantiate(wallPrefab, position, rotation);
        charges--;
        readyAt = Time.time + cooldown;
    }

    public void RefillCharges(int amount) => charges = Mathf.Max(0, charges + amount);
}
