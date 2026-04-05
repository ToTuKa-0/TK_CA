using UnityEngine;

/// <summary>
/// ボタンクリックでキャンバスが非表示になる
/// ボタンに設定
/// </summary>

public class ClickStartCanvas : MonoBehaviour
{
    [Tooltip("非表示にするキャンバスをアタッチ")] public GameObject canvas;
    [Tooltip("Timerのついてるオブジェクトをアタッチ")] public Timer timer;

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
