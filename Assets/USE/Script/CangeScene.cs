using UnityEngine;
using UnityEngine.SceneManagement;

/// <summary>
/// 画面左クリックでシーン移行
/// </summary>

public class CangeScene : MonoBehaviour
{
    [SerializeField] string SceneName;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            SceneManager.LoadScene(SceneName);
        }
    }
}
