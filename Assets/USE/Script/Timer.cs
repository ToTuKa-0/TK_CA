using TMPro;
using UnityEngine;

/// <summary>
/// https://osakanagames.com/blog/countdowntimer/
/// キャンバス消えたら動くタイマー
/// 0になったら答えを表示
/// 答え書くキャンバスも表示
/// </summary>

public class Timer : MonoBehaviour
{
    [SerializeField,Tooltip("動かすTextをアタッチ")] TextMeshProUGUI timerText;
    [SerializeField, Tooltip("次に飛ぶCanvasをアタッチ")] GameObject timeUpCanvas;
    [SerializeField, Tooltip("制限時間")] float timeLimit;

    bool isCounting = false;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public void StartTimer()
    {
        isCounting = true;

        timeUpCanvas.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (!isCounting) return;

        timeLimit -= Time.deltaTime;

        if (timeLimit < 0)
        {
            timeLimit = 0;
            isCounting = false;

            timeUpCanvas.SetActive(true);
        }

        timerText.text = timeLimit.ToString("F0");
    }
}
