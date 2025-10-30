using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class EndGameUI : MonoBehaviour
{
    public TMP_Text finalScoreText;

    void Start()
    {
        // Display the final score from GameManager
        if (finalScoreText != null)
        {
            finalScoreText.text = "Score: " + GameManager.finalScore;
        }
    }

    // Called when the "Play Again" button is clicked
    public void PlayAgain()
    {
        SceneManager.LoadScene("SampleScene");
    }

    public void BackToMainMenu()
    {
      
        SceneManager.LoadScene("MainMenuScene");
    }
}
