using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using FMODUnity;
using FMOD.Studio;

public class CoinPickup : MonoBehaviour
{
    public EventReference coinSound;
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
            
            RuntimeManager.PlayOneShot(coinSound, transform.position);
            
            // Destroy the coin
            Destroy(gameObject);
        }
    }
}
