using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    private GameObject player; //the player game object
    void Start()
    {
        player = GameObject.Find("Player"); //find gameobject with the tag player and store as player
    }

    void Update()
    {
        transform.position = new Vector3(player.transform.position.x, player.transform.position.y, transform.position.z); //sets the cameras position to be one with the player while staying in its current z position
    }
}
