using System.Collections;
using UnityEngine;

public class Ball : MonoBehaviour
{
    [SerializeField] float speed;
    [SerializeField] float randomForce;

    Rigidbody2D rb;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        StartCoroutine(nameof(StartMove));
    }

    public void ResetPosition()
    {
        transform.position = Vector2.zero;
        rb.linearVelocity = Vector2.zero;
        StartCoroutine(nameof(StartMove));
    }

    IEnumerator StartMove()
    {
        yield return new WaitForSeconds(1.5f);

        float horizontalSpeed = Random.Range(0, 2) == 0 ? speed : -speed;
        float verticalSpeed = Random.Range(0, 2) == 0 ? speed : -speed;
        rb.linearVelocity = new Vector2(horizontalSpeed, verticalSpeed);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        // Isso é para prevenir a bolinha de ficar em um loop infinito
        rb.linearVelocity += new Vector2(randomForce, randomForce);
    }
}
