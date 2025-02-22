using UnityEngine;
using UnityEngine.SceneManagement;

public class Ball : MonoBehaviour
{
    private Rigidbody2D myRigidbody;
    public float speedX;
    public float speedY;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        myRigidbody = this.gameObject.GetComponent<Rigidbody2D>();

        Vector2 force = new Vector2(speedX, speedY);

        myRigidbody.AddForce(force);
    }

    // Update is called once per frame
    void Update()
    {
        // 現在の速度を取得して表示
        //float currentSpeed = myRigidbody.linearVelocity.magnitude;
        //Debug.Log("Current Speed: " + currentSpeed);

        if(transform.position.y < -4.5f)
        {
            // Debug.Log("GameOver");
            // Time.timeScale = 0;
            SceneManager.LoadScene("GameOverScene");
        }
    }
}
