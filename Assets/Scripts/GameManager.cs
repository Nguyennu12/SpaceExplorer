using TMPro; 
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public int score = 0;
    public TMP_Text scoreText;
    public static int finalScore;
    void Start()
    {
        
        UpdateScoreText();
    }

    // Add points to the score
    public void AddScore(int points)
    {
        score += points;
        finalScore = score;
        UpdateScoreText();
        Debug.Log("Current Score: " + score);
    }

    // Update the score text on screen
    void UpdateScoreText()
    {
        if (scoreText != null)
        {
            scoreText.text = "Score: " + score;
        }
    }

    // Handle game over
    public void GameOver()
    {
        Debug.Log("GAME OVER!");
        SceneManager.LoadScene("EndGameScene");
    }
}
