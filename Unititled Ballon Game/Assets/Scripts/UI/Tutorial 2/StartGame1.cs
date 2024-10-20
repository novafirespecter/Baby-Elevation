using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartGame1 : MonoBehaviour
{
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space)) //when the player presses spacebar
        {
            SceneManager.LoadScene("Tutorial Level 2"); //load Tutorial Level 2
        }
    }
}
