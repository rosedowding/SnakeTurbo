using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine.Advertisements;

public class gameOver : MonoBehaviour {

    public GameObject gameOverCanvas;

    public GameObject mainGameMusic;
    public GameObject gameOverMusic;

    // Update is called once per frame
    void Update () {

		if (Player.Player.health <= 0)
        {
            Player.Player.speed = 0;
            //Stops the player from moving

            gameOverCanvas.SetActive(true);
            //Makes the game over screen appear

            mainGameMusic.SetActive(false);
            gameOverMusic.SetActive(true);
            //Stops playing the main music and starts playing Game Over music.

            if (Player.Player.points > Player.Player.highScore)
            {
                Player.Player.highScore = Player.Player.points;
                PlayerPrefs.SetInt("HighScore", Player.Player.highScore);
                PlayerPrefs.Save();
            }

        }
	}

    public void ResetGame() //This is ran when the "Return to Menu" button is clicked
    {
        Player.Player.points = 0;
        Player.Player.health = 100;
        //Relevant values are reset to defaults

        SceneManager.LoadScene("MainMenu");
        //Menu is loaded
    }
}
