using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Death2 : MonoBehaviour
{
    public RedoGame retry; //referenc redogame script

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player")) //if the collider hits playerTag
        {
            GameObject player = GameObject.FindWithTag("Player"); //store gameobject as player

           if(player != null)
            {
                RedoGame respawn = player.GetComponent<RedoGame>(); //take redogame script from player and store as respawn

                if(respawn != null)
                {
                    respawn.PlayerDied("Tutorial Level 3"); //sets the scence the player should be spawned in
                    respawn.RespawnPlayer(); //restracts the scence esstianlly respawning the player
                }
            }

        }
    }
}
