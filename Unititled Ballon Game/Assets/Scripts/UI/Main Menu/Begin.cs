using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Begin : MonoBehaviour
{
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space)) //when the player presses spacebar
        {
            BeginGame(); 
        }
    }


    void BeginGame()
    {
        SceneManager.LoadScene("Tutorial", LoadSceneMode.Single); //load the tutorial scence
    }
}
