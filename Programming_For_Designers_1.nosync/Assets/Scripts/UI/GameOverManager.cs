using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOverManager : MonoBehaviour
{
    // Method to reset the game
    private void ResetGame()
    {
        // Reset the lives count
        PlayerDeath.lives = 3;

        // Reset the coins count
        CoinManager.coinCount = 0;
    }

    // Method to restart the game
    public void RestartGame()
    {
        // Reset the game
        ResetGame();

        // Reset the lives count

        PlayerDeath.lives = 3;

        // Reset the coins count
        CoinManager.coinCount = 0;

        // Unfreeze the game
        Time.timeScale = 1;

        // Reload the current scene
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    // Method to go back to the main menu
    public void GoToMainMenu()
    {
        // Reset the game
        ResetGame();
        
        // Unfreeze the game
        Time.timeScale = 1;

        // Load the main menu scene
        // Replace "MainMenu" with the name of your main menu scene
        SceneManager.LoadScene("MainMenu");
    }
}
