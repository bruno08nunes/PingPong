using UnityEngine;

public class Ball : MonoBehaviour
{
    [SerializeField] float speed;

    Rigidbody2D rb;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.linearVelocity = new Vector2 (speed, speed);
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        
    }
}
