using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;
using UnityEngine.EventSystems;

public class MainMenuController : MonoBehaviour
{
    public TextMeshProUGUI playGameText;

    private void Start()
    {
        // Get the TextMeshProUGUI component
        playGameText = GetComponentInChildren<TextMeshProUGUI>();
    }
    public void PlayGame()
    {
        // Load the main game scene
        // Replace "MainGame" with the name of your main game scene
        SceneManager.LoadScene("MainGame");
    }

    public void QuitGame()
    {
        // Quit the game
        Application.Quit();
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        // Change the color of the text to red when the mouse hovers over the PlayGame button
        playGameText.color = Color.red;
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        // Change the color of the text back to white when the mouse leaves the PlayGame button
        playGameText.color = Color.white;
    }
}
