using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndLoadMenu : MonoBehaviour
{
    public void OnEnable()
    {
        SceneManager.LoadScene("MainMenu");
    }
}