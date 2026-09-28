using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class updateHealthAndPoints : MonoBehaviour {

    public int timer;
    //Creates an integer to use as a timer

	// Use this for initialization
	void Start () {
        timer = 0;
        //Sets default timer value

	}
	
	// Update is called once per frame
	void Update () {
        timer += 1;
        //Increases the value of timer by 1 every frame
        
        if (timer % 75 == 0 && Player.Player.health > 0)
        {
            Player.Player.health -= 2;
        }

        if (timer % 25 == 0 && Player.Player.health > 0)
        {
            Player.Player.points += 2;
        }

        if (Player.Player.health < 0)
        {
            Player.Player.health = 0;

            //The game ends when the player's health reaches 0 or below.
            //For cosmetic purposes, we don't want health going below 0, so we can use this code to reset it.

        }

        else if (Player.Player.health > 100)
        {
            Player.Player.health = 100;

            //Similarly, the player's health should not go above 100, so we reset it using this code whenever it does go above 100

        }
	}
}
