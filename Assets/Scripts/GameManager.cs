using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI scoreText;

    float player1Score;
    float player2Score;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        ResetScore();

        Cursor.visible = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Escape))
        {
            SceneManager.LoadScene("Menu");
        }

        if (Input.GetKey(KeyCode.R))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
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
