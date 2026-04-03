using UnityEngine;

/// <summary>
/// ボタンクリックでキャンバスが非表示になる
/// </summary>

public class ClickCanvas : MonoBehaviour
{
    public GameObject canvas;
    public TimeCount timeCount;

    public void Hide()
    {
        if (canvas != null)
        {
            canvas.SetActive(false);

            if (timeCount != null)
            {
                timeCount.StartTimer();
            }
        }
    }
}
