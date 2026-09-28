using System;
using System.Collections.Generic;
using Unity;
using UnityEngine;
using UnityEngine.UI;

namespace Player
{
    public class Player
    {
        public static float health;
        //The player's health

        public static float speed;
        //The speed at which the apples move towards the player at

        public static float playerSpeed;
        //The speed at which the player can move up and down

        public static int points;
        //The number of points the player has

        public static float waitSeconds;
        //The time the game waits before spawning another apple

        public static int highScore;
        //The player's high score

        public Player (float _health, float _speed, float _playerSpeed, int _points, float _waitSeconds, int _highScore)
        {
            _health = health;
            _speed = speed;
            _playerSpeed = playerSpeed;
            _points = points;
            _waitSeconds = waitSeconds;
            _highScore = highScore;
        }

        public static void RedApple()
        {
            Player.points += 50;
            //Increases the player's score by 50

            Player.health += 6;
            //Increases the player's health by 6

            if (Player.speed < (float)5000)
            {
                Player.speed += (float)100;
                //Increases the player's horizontal speed by 300, so long as it is below the maximum speed

            }

            if (Player.playerSpeed < 65)
            {
                Player.playerSpeed += (float)1;
                //Increases the player's vertical speed by 1, so long as it is below the maximum
            }

            if (Player.waitSeconds > 0.25)
            {
                Player.waitSeconds -= (float)0.3;
                //Decreases the number of seconds inbetween an apple spawning by 0.3 seconds.
            }
            
        }

        public static void GoldenApple()
        {
            Player.points += 250;
            //Increases the player's score by 250

            if (Player.speed < (float)5000)
            {
                Player.speed += (float)150;
                //Increases the player's horizontal speed by 350, as long as their speed is below the maximum

            }

            if (Player.playerSpeed < 65)
            {
                Player.playerSpeed += (float)2;
                //Increases the player's vertical speed by 2, as long as their speed is below the maximum
            }

            if (Player.waitSeconds > 0.25)
            {
                Player.waitSeconds -= (float)0.2;
                //Decreases the time between apple spawning by 0.2 seconds
            }

            float healthCheck = Player.health + 15;

            if (healthCheck < 100)
            {
                Player.health += 15;
            }

            else
            {
                Player.health = 100;
            }

            //Checks if increasing the player's health will make it higher than 100, and sets it to 100 only if it is higher than 100.

        }

        public static void PoisonApple()
        {
            int pointCheck = Player.points - 100;

            if (pointCheck < 0)
            {
                Player.points = 0;
            }

            else
            {
                Player.points -= 100;
            }

            //Checks if decreasing the player's score by 100 will make it lower by 0, and sets it to 0 only if it is true

            Player.health -= 20;
            //Decreases the player's health by 20

        }
    }

}
