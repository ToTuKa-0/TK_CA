using UnityEngine;
using UnityEngine.SceneManagement;

/// <summary>
/// クリックでシーン移行
/// </summary>

public class ClickChange : MonoBehaviour
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
