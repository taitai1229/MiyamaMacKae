using UnityEngine;
using UnityEngine.SceneManagement;

public class ClearScript : MonoBehaviour
{
   private int blockCount;

    void Start()
    {
        // シーン内のブロックの数をカウント
        blockCount = GameObject.FindGameObjectsWithTag("Block").Length;
    }

    public void BlockDestroyed()
    {
        blockCount--;

        // すべてのブロックが壊れたらクリア画面に遷移
        if (blockCount <= 0)
        {
            SceneManager.LoadScene("ClearScene"); // クリアシーンの名前を適宜設定
        }
    }
}
