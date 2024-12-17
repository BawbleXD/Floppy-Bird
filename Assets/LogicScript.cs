using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LogicScript : MonoBehaviour
{
    public int playerScore;
    public Text scoreText;
    public GameObject gameOverScreen;
    public AudioSource dingSFX;
    public AudioSource deathNormalSFX;
    public AudioSource deathDemonSFX;
    private bool isSoundPlayed;

    [ContextMenu("Increase Score")]
    // public = function can be accessed from another script
    public void addScore(int scoreToAdd)
    {
        // Add player score by 1
        playerScore = playerScore + scoreToAdd;
        // convert player score to int and show in the UI
        scoreText.text = playerScore.ToString();
        dingSFX.Play();
    }

    // Function to go to the starting scene again
    public void restartGame()
    {
        // Start the scene again
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    // Easter egg for demon sound (3% chance)
    private void randomDeathSound()
    {
        int randint = Random.Range(1,101);
        if (randint > 3) //97% of the time
        {
            //if death sound is being played, dont play another death sound.
            if (isSoundPlayed == false)
            {
                deathNormalSFX.Play();
                isSoundPlayed = true;
            }
        }
        else //3% of the time
        {
            //if death sound is being played, dont play another death sound.
            if (isSoundPlayed == false)
            {
                deathDemonSFX.Play();
                isSoundPlayed = true;
            }
        }
    }

    // function to load game scene
    public void gameOver()
    {
        randomDeathSound();
        gameOverScreen.SetActive(true);
    }
}
