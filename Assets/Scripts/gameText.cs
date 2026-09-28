using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Player;

public class gameText : MonoBehaviour {

    public Text healthText;
    public Text pointsText;
    public Text highScoreText;
    //These are displayed on the game screen.
	
	// Update is called once per frame
	void Update () {
        healthText.text = Convert.ToString(Player.Player.health);
        pointsText.text = Convert.ToString(Player.Player.points);
        highScoreText.text = "Best: " + Convert.ToString(Player.Player.highScore);
        //Converts the variables (which are stored as integers) to strings and assigns them to the onscreen text values
	}
}
