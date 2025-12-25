using UnityEngine;

public class GameManager : MonoBehaviour
{
    float player1Score;
    float player2Score;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
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

            Debug.Log(player1Score);
            return;
        }

        player2Score++;
        Debug.Log(player2Score);
    }

    public void ResetScore()
    {
        player1Score = 0;
        player2Score = 0;
    }
}
