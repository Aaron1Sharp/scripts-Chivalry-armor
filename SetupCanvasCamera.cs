
using System.Collections.Generic;
using UnityEngine;

public class SetupCanvasCamera : MonoBehaviour
{
    void Awake()
    {
        var canvas = GetComponent<Canvas>();
        if (canvas.renderMode == RenderMode.ScreenSpaceCamera || canvas.renderMode == RenderMode.WorldSpace)
        {
            canvas.worldCamera = Camera.main; // Предполагая, что основная камера у вас тегирована как "MainCamera"
        }
    }
}
