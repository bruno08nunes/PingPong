using UnityEngine;

public class Goal : MonoBehaviour
{
    [SerializeField] bool playerOneScored;

    GameManager gameManager;
    Ball ball;

    AudioSource audioSource;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        gameManager = GameObject.Find("Game Manager").GetComponent<GameManager>();
        ball = GameObject.Find("Ball").GetComponent<Ball>();

        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        gameManager.IncrementPlayerScore(playerOneScored);
        ball.ResetPosition();
        audioSource.Play();
    }
}
