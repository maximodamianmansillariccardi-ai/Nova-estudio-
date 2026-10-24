using UnityEngine;

public class SensitivitySettings : MonoBehaviour
{
    private const string SensitivityKey = "PS_LOOK_SENSITIVITY";
    [SerializeField] private MobileLook mobileLook;
    [SerializeField, Range(0.02f, 0.5f)] private float defaultSensitivity = 0.12f;

    private void Start()
    {
        float saved = PlayerPrefs.GetFloat(SensitivityKey, defaultSensitivity);
        Apply(saved);
    }

    public void Apply(float value)
    {
        value = Mathf.Clamp(value, 0.02f, 0.5f);
        if (mobileLook) mobileLook.SetSensitivity(value);
        PlayerPrefs.SetFloat(SensitivityKey, value);
        PlayerPrefs.Save();
    }
}
