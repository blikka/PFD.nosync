using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CoinCounter : MonoBehaviour
{
    public TextMeshProUGUI coinText; // Use TextMeshProUGUI for text
    // Update is called once per frame
    void Update()
    {
        coinText.text = "Coins: " + CoinManager.coinCount; // Update the text to show the number of coins
    }
}
