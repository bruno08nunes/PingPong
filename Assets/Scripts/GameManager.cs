using TMPro;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI scoreText;

    float player1Score;
    float player2Score;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        ResetScore();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void IncrementPlayerScore(bool playerOneScored)
    {
        if (playerOneScored)
        {
            player1Score++;

            UpdateScoreText();

            return;
        }

        player2Score++;
        UpdateScoreText();
    }

    public void ResetScore()
    {
        player1Score = 0;
        player2Score = 0;
        UpdateScoreText();
    }

    void UpdateScoreText()
    {
        scoreText.text = $"{player1Score} X {player2Score}";
    }
}
