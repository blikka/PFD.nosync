using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class LivesManager : MonoBehaviour
{
    public GameObject livesTextObject; // Reference to the Lives text object

    // Start is called before the first frame update
    void Start()
    {
        UpdateLivesText();
    }

    // Update is called once per frame
    void Update()
    {
        UpdateLivesText();
    }

        void UpdateLivesText()
    {
        // Get the TextMeshProUGUI component and update its text
        TextMeshProUGUI livesText = livesTextObject.GetComponent<TextMeshProUGUI>();
        livesText.text = "Lives: " + PlayerDeath.lives;
    }
}
