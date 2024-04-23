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
    public AudioSource margaya;
    public AudioSource deadhit;

    public Text highScore;

    [ContextMenu("IS")]
    public void addScore(int scoreToAdd)
    {
        playerScore = playerScore + scoreToAdd;
        scoreText.text  = playerScore.ToString();   
        if(playerScore > PlayerPrefs.GetInt("highScore"))
        {
            PlayerPrefs.SetInt("highScore", playerScore);
        }
    }

    public void restartGame()
    {
        margaya.Stop();
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void gameOver()
    {
        highScore.text = PlayerPrefs.GetInt("highScore").ToString();
        margaya.Play();
        deadhit.Play();
        gameOverScreen.SetActive(true);
    }

}
