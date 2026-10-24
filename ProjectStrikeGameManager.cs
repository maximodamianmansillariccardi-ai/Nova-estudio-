using UnityEngine;

public class ProjectStrikeGameManager : MonoBehaviour
{
    private void Awake()
    {
        Screen.orientation = ScreenOrientation.Landscape;
        Application.targetFrameRate = 60;
    }

    // Hook a quality selector UI to this method.
    public void SetQualityLevel(int level)
    {
        QualitySettings.SetQualityLevel(Mathf.Clamp(level, 0, QualitySettings.names.Length - 1), true);
    }
}
