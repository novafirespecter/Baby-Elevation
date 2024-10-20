using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartGame : MonoBehaviour
{
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space)) //when the player presses Spacebar
        {
            SceneManager.LoadScene("Tutorial Level 1"); // Load Tutorial Level 1
        }
    }
}
