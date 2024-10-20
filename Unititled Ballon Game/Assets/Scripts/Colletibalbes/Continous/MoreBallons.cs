using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoreBallons : MonoBehaviour
{
    public int moreBallons; //how many ballons the player gets
    public PlayerMovement playerMovement; //the playermovement script
    public AudioSource balloonCollect.

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player")) //if the collider hits playerTag
        {
            GameObject player = GameObject.FindWithTag("Player"); //store hit gameobject as player

            if (player != null) //if player is not null
            {
                PlayerMovement move = player.GetComponent<PlayerMovement>(); //get playermovement script and store as move

                if (move != null) //if health is not null
                {
                    move.getBallons(moreBallons); //this gives the player ballons
                    balloonCollect.Play();
                    Destroy(gameObject); //this destroys the ballon

                }

            }

        }
    }
}
