using UnityEngine;

public class WeaponRaycast : MonoBehaviour
{
    [SerializeField] private Camera aimCamera;
    [SerializeField] private float damage = 25f;
    [SerializeField] private float range = 120f;
    [SerializeField] private float shotsPerSecond = 8f;
    [SerializeField] private LayerMask hitMask = ~0;
    private float nextShotTime;

    // Connect this to the fire button's PointerDown/hold logic.
    public void TryFire()
    {
        if (Time.time < nextShotTime || !aimCamera) return;
        nextShotTime = Time.time + 1f / Mathf.Max(0.1f, shotsPerSecond);

        if (Physics.Raycast(aimCamera.transform.position, aimCamera.transform.forward,
            out RaycastHit hit, range, hitMask, QueryTriggerInteraction.Ignore))
        {
            Health target = hit.collider.GetComponentInParent<Health>();
            if (target) target.ApplyDamage(damage);
        }
    }
}
