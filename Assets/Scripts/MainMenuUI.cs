using UnityEngine;
using UnityEngine.SceneManagement; 

public class MainMenuUI : MonoBehaviour
{
    public GameObject instructionsPanel; 

    // Called when the "Play" button is clicked
    public void PlayGame()
    {
        SceneManager.LoadScene("SampleScene"); 
    }

    // Called when the "Instructions" button is clicked
    public void ShowInstructions()
    {
        instructionsPanel.SetActive(true); 
    }

    // Called when the "Close" button on the instructions panel is clicked
    public void HideInstructions()
    {
        instructionsPanel.SetActive(false); 
    }

    // Called when the "Quit" button is clicked
    public void QuitGame()
    {
        Debug.Log("Quit game!");
        Application.Quit();
    }
}
