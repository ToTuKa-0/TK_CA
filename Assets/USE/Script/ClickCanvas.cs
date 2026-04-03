using UnityEngine;

public class ClickCanvas : MonoBehaviour
{
    [SerializeField] GameObject canvas;

    public void Hide()
    {
        if (canvas != null)
        {
            canvas.SetActive(false);
        }
    }
}
