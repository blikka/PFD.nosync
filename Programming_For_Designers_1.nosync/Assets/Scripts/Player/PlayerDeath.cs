using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class PlayerDeath : MonoBehaviour
{
    public static int lives = 3; // Start with 3 lives
    public GameObject gameOverText; // Reference to the Game Over text

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Water") || other.gameObject.CompareTag("Gator"))
        {
            Die();
        }
    }

    void Die()
    {
        // Decrement the lives count
        lives--;

        // If the player has no more lives, end the game
        if (lives <= 0)
        {
            // Display the Game Over text
            gameOverText.gameObject.SetActive(true);

            // Freeze the game
            Time.timeScale = 0;
        }
        else
        {
            // Reload the current scene
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);

            // Reset the coin count
            CoinManager.coinCount = 0;
        }
    }
}