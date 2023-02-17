using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; //need to do this to access Text
using UnityEngine.SceneManagement;

public class LogicScript : MonoBehaviour
{
    public int playerScore;
    public Text scoreText;
    public GameObject gameOverScreen;

    [ContextMenu("Increase Score")]
    public void addScore(int scoreToAdd) //public since we wanna access in other scripts
    {
        playerScore = playerScore + scoreToAdd;
            scoreText.text = playerScore.ToString();
    }

    public void restartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
    public void gameOver()
    {
        gameOverScreen.SetActive(true);
    }
}
