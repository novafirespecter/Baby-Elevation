using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayersHealth : MonoBehaviour
{
    public float maxHealth; //max health in the game
    public float currentHealth; //current health in the game
    public HealthBars healthBar; //reference to the healthBar game object

    void Start()
    {
        currentHealth = maxHealth; //set current health to max health
        healthBar.SetMaxHealth(maxHealth); //set health bar to max health  

    }

    public void LossHealth(float gains)
    {
        currentHealth -= gains; //this adds health to the currenthealth and assigns the current health 
        healthBar.SetHealth(currentHealth); // set the health bar to the new amaount

        if (currentHealth <= 0) //if health is less than or equal to 0 call die function
        {
            SceneManager.LoadScene("LevelLostScene"); //load the game over screePrint
            Debug.Log("Dead");
        }
    }

    //Brakeys.(2020, Febuary 9). How to make a Health bar in Unity![Video] https://www.youtube.com/watch?v=BLfNP4Sc_iA&list=PLt1E2jJc5nDj6KQi6BVJElz3vqFmg-B8I&index=4 
}