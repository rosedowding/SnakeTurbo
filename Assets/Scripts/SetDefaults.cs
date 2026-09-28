using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Player;

public class SetDefaults : MonoBehaviour {

        void Start()
        {
            Player.Player.speed = 1000;
            Player.Player.playerSpeed = 28;
            Player.Player.health = 100;
            Player.Player.points = 0;
            Player.Player.waitSeconds = (float)1.0;
            Player.Player.highScore = PlayerPrefs.GetInt("HighScore");

        }
    }
