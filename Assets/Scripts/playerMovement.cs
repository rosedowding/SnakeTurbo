using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMovement : MonoBehaviour {

    //This script should be attached to the player only!

    public GameObject upperBoundary;
    public GameObject lowerBoundary;

    public BoxCollider2D upperCollision;
    public BoxCollider2D lowerCollision;

    //upperCollision and lowerCollision are attached to their GameObject counterparts above, which are otherwise empty

    public BoxCollider2D playerCollision;
    //References the player's collision

    // Update is called once per frame
    void Update () {
        if (Input.GetKey("down") && Player.Player.health > 0)
        {
            transform.Translate(new Vector3(Player.Player.playerSpeed, 0, 0));
            //Moves the player down when the down key is pressed
        }

        else if (Input.GetKey("up") && Player.Player.health > 0)
        {
            transform.Translate(new Vector3(-Player.Player.playerSpeed, 0, 0));
            //Moves the player up when the up key is pressed
        }

        if (playerCollision.IsTouching(upperCollision))
        {
            transform.Translate(new Vector3(Player.Player.playerSpeed, 0, 0));
            //Automatically pushes the player down if they are touching the upper boundary of the scene
        }

        else if (playerCollision.IsTouching(lowerCollision))
        {
            transform.Translate(new Vector3(-Player.Player.playerSpeed, 0, 0));
            //Automatically pushes the player up if they are touching the lower boundary of the scene
        }
    }
}
