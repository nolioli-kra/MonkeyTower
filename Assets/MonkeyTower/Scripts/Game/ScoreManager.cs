using UnityEngine;

public class ScoreManager : MonoBehaviour
{
    public PlayerScore playerScore;

    void Start()
    {
        if (playerScore != null)
        {
            // Initialize the score
            playerScore.score = 0;
        }
    }

    public void AddPoints(int points)
    {
        if (playerScore != null)
        {
            playerScore.score += points;
            Debug.Log("Player Score: " + playerScore.score);
        }
    }
}
