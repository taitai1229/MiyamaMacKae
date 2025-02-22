using UnityEngine;

public class Block : MonoBehaviour
{
    private ClearScript clearScript;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    private void Start()
    {
        clearScript = FindFirstObjectByType<ClearScript>(); // 事前に取得
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name == "Ball")
        {
            Destroy(this.gameObject);

            // ClearScript に通知
            clearScript.BlockDestroyed();
        }
    }
}
