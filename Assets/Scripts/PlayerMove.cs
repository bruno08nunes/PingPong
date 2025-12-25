using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    Rigidbody2D rb;

    [SerializeField] float speed;
    [SerializeField] bool isSinglePlayer;
    [SerializeField] bool isPlayerOne;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb =  GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        MovePlayer();
    }

    void MovePlayer()
    {
        if (isSinglePlayer)
        {
            float verticalSpeed = Input.GetAxisRaw("Vertical") * speed;
            rb.linearVelocityY = verticalSpeed;
            return;
        }

        if (isPlayerOne)
        {
            MovePlayerOne();
            return;
        }

        MovePlayerTwo();
    }

    void MovePlayerOne()
    {
        if (Input.GetKey(KeyCode.W))
        {
            rb.linearVelocityY = speed;
            return;
        }

        if (Input.GetKey(KeyCode.S))
        {
            rb.linearVelocityY = -speed;
            return;
        }

        rb.linearVelocityY = 0;
    }

    void MovePlayerTwo()
    {
        if (Input.GetKey(KeyCode.UpArrow))
        {
            rb.linearVelocityY = speed;
            return;
        }

        if (Input.GetKey(KeyCode.DownArrow))
        {
            rb.linearVelocityY = -speed;
            return;
        }

        rb.linearVelocityY = 0;
    }
}
