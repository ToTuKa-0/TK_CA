using TMPro;
using UnityEngine;

/// <summary>
/// https://osakanagames.com/blog/countdowntimer/
/// キャンバス消えたら動くタイマー
/// 0になったら答えを表示
/// カウントダウンが少し早いため少し長めに秒数を設定
/// </summary>

public class TimeCount : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI timerText;
    [SerializeField] float timeLimit;

    bool isCounting = false;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public void StartTimer()
    {
        isCounting = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (!isCounting) return;

        timeLimit-= Time.deltaTime;

            timeLimit -= Time.deltaTime;

            if (timeLimit < 0)
            {
                timeLimit = 0;
            isCounting = false;
            }

            timerText.text = timeLimit.ToString("F0");
    }
}
