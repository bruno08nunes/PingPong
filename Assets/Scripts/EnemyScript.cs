using UnityEngine;

public class EnemyScript : MonoBehaviour
{
    GameObject ball;

    Rigidbody2D rb;

    [SerializeField] float speed;
    [SerializeField] float margin;

    private void Start()
    {
        ball = GameObject.Find("Ball");
        rb = GetComponent<Rigidbody2D>();
    }

    private void FixedUpdate()
    {
        if (ball.transform.position.y > transform.position.y + margin)
        {
            rb.linearVelocityY = speed;
            return;
        }

        if (ball.transform.position.y < transform.position.y - margin)
        {
            rb.linearVelocityY = -speed;
            return;
        }

        rb.linearVelocityY = 0;
    }
}
