using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinPickup : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            // Increment the coin count
            CoinManager.coinCount++;

            // Check if the coin count is a multiple of 10
            if (CoinManager.coinCount % 10 == 0)
            {
                // Give the player an extra life
                PlayerDeath.lives++;

                // Reset the coin count
                CoinManager.coinCount = 0;
            }

            // Destroy the coin
            Destroy(gameObject);
        }
    }
}
