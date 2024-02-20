using UnityEngine;
using UnityEngine.UI;

public class DisplayScreenInfo : MonoBehaviour
{
    public Text screenInfoText;

    void Start()
    {
        UpdateScreenInfo();
    }

    void UpdateScreenInfo()
    {
        if (screenInfoText == null)
        {
            Debug.LogError("ScreenInfoText is not assigned!");
            return;
        }

        int screenWidth = Screen.width;
        int screenHeight = Screen.height;
        float dpi = Screen.dpi;
        float screenWidthInches = screenWidth / dpi;
        float screenHeightInches = screenHeight / dpi;
        float screenSizeInches = Mathf.Sqrt(screenWidthInches * screenWidthInches + screenHeightInches * screenHeightInches);

        string info = $"Resolution: {screenWidth} x {screenHeight}\n" +
                      $"DPI: {dpi}\n" +
                      $"Screen Size (inches): {screenSizeInches:F2}";
        screenInfoText.text = info;
    }
}
