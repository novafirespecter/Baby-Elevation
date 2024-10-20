using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameEnd : MonoBehaviour
{
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space)) //when the player presses Spacebar
        {
            BeginGame();
        }
    }


    void BeginGame()
    {
        SceneManager.LoadScene("MainMenu", LoadSceneMode.Single); //load the menu scence
    }
}
