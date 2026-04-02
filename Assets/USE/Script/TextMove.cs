using UnityEngine;

/// <summary>
/// Text‚ª“®‚­
/// https://zenn.dev/daichi_gamedev/articles/69471ad4a91029
/// </summary>

public class TextMove : MonoBehaviour
{
    float time, changeSpeed;
    bool move;

    void Start()
    {
        move = true;
    }

    void Update()
    {
        changeSpeed = Time.deltaTime * 0.5f;

        if (time < 0)
        {
            move = true;
        }
        if (time > 0.7f)
        {
            move = false;
        }

        if (move == true)
        {
            time += Time.deltaTime;
            transform.localScale += new Vector3(changeSpeed, changeSpeed, changeSpeed);
        }
        else
        {
            time -= Time.deltaTime;
            transform.localScale -= new Vector3(changeSpeed, changeSpeed, changeSpeed);
        }
    }
}
