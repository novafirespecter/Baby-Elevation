using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetScence2 : MonoBehaviour
{
    public RedoGame retry; //the redogame script reference
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player")) //if the collider hits playerTag
        {
            GameObject player = GameObject.FindWithTag("Player"); //store hit game object as player 

            if (player != null)
            {
                RedoGame respawn = player.GetComponent<RedoGame>(); //gets script from player and stores as respawn 

                if (respawn != null)
                {
                    respawn.PlayerDied("Tutorial Level 2"); //sets the respawn scence 
                }
            }

        }
    }
}
