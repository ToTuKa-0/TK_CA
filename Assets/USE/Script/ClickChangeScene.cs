using UnityEngine;
using UnityEngine.SceneManagement;

/// <summary>
/// ボタンクリックでシーン変更
/// わかるようにそれぞれのキャンバスにこれをアタッチ
/// </summary>

public class ClickChangeScene : MonoBehaviour
{
    [SerializeField] string nextSceneName;

    public void ChangeScene()
    {
        SceneManager.LoadScene(nextSceneName);
    }
}
