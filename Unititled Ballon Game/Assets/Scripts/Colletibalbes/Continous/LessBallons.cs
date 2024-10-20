using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LessBallons : MonoBehaviour
{
    public int moreBallons; //how many ballons the player losses
    public PlayerMovement playerMovement; //the playermovement script
    public AudioSource balloonPopping;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player")) //if the collider hits playerTag
        {
            GameObject player = GameObject.FindWithTag("Player"); //store hit gameobject as player

            if (player != null) //if player is not null
            {
                PlayerMovement move = player.GetComponent<PlayerMovement>(); //get playermovement script and store as mov

                if (move != null) //if health is not null
                {
                    move.loseBallons(moreBallons); //this reduces the amount of ballons the player has
                    balloonPopping.Play();
                }

            }

        }
    }
}
