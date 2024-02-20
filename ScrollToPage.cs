using UnityEngine;
using UnityEngine.UI;

public class ScrollToPage : MonoBehaviour
{
    public ScrollRect scrollRect;
    public float scrollSpeed = 10f;
    private bool isScrolling;
    private float targetPosition;

    public void ScrollTo(float position)
    {
        targetPosition = position;
        isScrolling = true;
    }

    private void Update()
    {
        if (isScrolling)
        {
            scrollRect.verticalNormalizedPosition = Mathf.MoveTowards(scrollRect.verticalNormalizedPosition, targetPosition, scrollSpeed * Time.deltaTime);
            if (Mathf.Approximately(scrollRect.verticalNormalizedPosition, targetPosition))
            {
                isScrolling = false;
            }
        }
    }
}
