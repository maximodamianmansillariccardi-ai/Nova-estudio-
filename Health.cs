using UnityEngine;
using UnityEngine.Events;

public class Health : MonoBehaviour
{
    [SerializeField] private float maxHealth = 100f;
    [SerializeField] private UnityEvent onEliminated;
    public float CurrentHealth { get; private set; }
    public float MaxHealth => maxHealth;

    private void Awake() => CurrentHealth = maxHealth;

    public void ApplyDamage(float amount)
    {
        if (CurrentHealth <= 0f || amount <= 0f) return;
        CurrentHealth = Mathf.Max(0f, CurrentHealth - amount);
        if (CurrentHealth <= 0f) onEliminated?.Invoke();
    }

    public void RestoreFullHealth() => CurrentHealth = maxHealth;
}
