using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class logicManager : MonoBehaviour
{
    public int playerScore;
    public Text scoretext;
    public GameObject gameover;  

    [ContextMenu("Increase score")]
    public void addScore(int scoretoadd)
    {
        playerScore = playerScore + scoretoadd;
        scoretext.text = playerScore.ToString();
    }

    public void restartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);   
    }

    public void gameOver()
    {
        gameover.SetActive(true);
    }
}

