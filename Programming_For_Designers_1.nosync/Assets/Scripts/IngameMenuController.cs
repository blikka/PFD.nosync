using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IngameMenuController : MonoBehaviour
{
    public GameObject ingameMenu;
    public Move playerMove;

    // Start is called before the first frame update
    void Start()
    {
        ingameMenu.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if(Time.timeScale == 0)
            {
            ingameMenu.SetActive(false);
            playerMove.enabled = true;
            Time.timeScale = 1;
            }
            else
            {
            Time.timeScale = 0;
            ingameMenu.SetActive(true);
            playerMove.enabled = false;
            }
        }
    }
}
