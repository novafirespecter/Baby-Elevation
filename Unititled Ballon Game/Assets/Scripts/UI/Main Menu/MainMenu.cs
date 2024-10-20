using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
     // (OpenAI, 2024)
    public void PlayGame()
    {
        SceneManager.LoadScene("IntroGame"); // Load IntroGame scence
    }

    public void Level1()
    {
        SceneManager.LoadScene("Tutorial Level 3"); // Load Tutorial Level 3 scence
    }

    public void Level2()
    {
        SceneManager.LoadScene("Tutorial Level 2"); // Load Tutorial Level 2
    }

    public void Level3()
    {
        SceneManager.LoadScene("Level 2"); // Load Level 2
    }

    public void ExitGame()
    {
        Application.Quit(); // Exit the application
    }

    /* References:
    Webname: ChatGPT
    Author: OpenAI
    Date: 16 March 2024
    Code Version: N/A
    URL: https://chat.openai.com/c/1c2b33fd-d052-427a-b06d-d01d2612b036 
    */
}
