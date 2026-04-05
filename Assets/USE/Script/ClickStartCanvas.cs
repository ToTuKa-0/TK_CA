using UnityEngine;

/// <summary>
/// ボタンクリックでキャンバスが非表示になる
/// ボタンに設定
/// </summary>

public class ClickStartCanvas : MonoBehaviour
{
    public GameObject canvas;
    public Timer timer;

    public void Hide()
    {
        if (canvas != null)
        {
            canvas.SetActive(false);

            if (timer != null)
            {
                timer.StartTimer();
            }
        }
    }
}
