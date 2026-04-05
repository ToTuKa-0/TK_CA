using TMPro;
using UnityEngine;

/// <summary>
/// 正解不正解で決められたキャンバスに飛ぶ
/// </summary>

public class Answers : MonoBehaviour
{
    [SerializeField, Tooltip("文字を記入するやつをアタッチ")] TMP_InputField inputField;
    [SerializeField, Tooltip("正解のCanvas")] GameObject correct;
    [SerializeField, Tooltip("不正解のCanvas")] GameObject Incorrect;
    [SerializeField, Tooltip("答えを記入")] string answer;

    public void CheckInput()
    {
        string userInput = inputField.text;

        if (userInput == answer)
        {
            correct.SetActive(true);
            Incorrect.SetActive(false);
        }
        else
        {
            correct.SetActive(false);
            Incorrect.SetActive(true);
        }
    }
}