using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; //We need to be using the UnityEngine.UI namespace in order to work with UI elements

public class creditText : MonoBehaviour
{

    public string[] credits = new string[4]; //Array to contain all 4 names and roles
    public Text creditsUIText; //UI text to reference the onscreen text objects

    //Runs once when first started
    void Start()
    {
        credits[0] = "Game Design/Programming by Rose Dowding";
        credits[1] = "Graphics by Jack Hilton & OpenGameArt";
        credits[2] = "Music by Eric Matyas (www.soundimage.org)";
        credits[3] = "Ginger Snake font by Gulash (FontSpace)";
        //Here I am adding each credit to the list

        StartCoroutine(UpdateCredits());
        //Here I am telling the program to run the coroutine below called UpdateCredits. A coroutine is procedure that works with time and is able to pause for specified periods
    }

    IEnumerator UpdateCredits()
    {

        for (int i = 0; i < 4; i++) //A for loop that repeats 3 times
        {
            creditsUIText.text = credits[i];
            //Setting the onscreen value to the current credit

            yield return new WaitForSeconds(3);
            //The program pauses, leaving the credit onscreen for a bit

            creditsUIText.text = "";
            //The onscreen value is set to be nothing in order to create a flashing effect

            yield return new WaitForSeconds(1);
            //Waits for 1 second before looping with the next credit

            if (i == 3) //If the loop is on its fourth run... (remember, we start counting from 0!)
            {
                i = -1; //... we want to change i back to 0 and reset the loop
                        //In order to get i to 0, we have to set it to -1 here as the loop increases the value of i by 1 everytime it runs
            }
        }

    }
}
