using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Begin1 : MonoBehaviour
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
        SceneManager.LoadScene("Tutorial Level 3", LoadSceneMode.Single); //load Tutorial Level 3
    }
}
