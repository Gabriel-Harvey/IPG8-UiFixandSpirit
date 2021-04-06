using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    static private float time = 0;
    static public int playerScore = 0;
    static public int lives = 3;
    public GameObject playerScoreUI;
    public GameObject timeUI;
    public GameObject Newlives;
    public Spawner Spawner;


    void Update()
    {
        time += Time.deltaTime;
        timeUI.gameObject.GetComponent<Text>().text = ("Time: " + (int)time);
        playerScoreUI.gameObject.GetComponent<Text>().text = ("Score: " + playerScore);
        Newlives.gameObject.GetComponent<Text>().text = ("Lives: " + lives);
    }
  

    public void Score_increase()
    {
        playerScore += 10;
    }

    public void checkLives()
    {
        if (lives < 4)
        {
            Spawner.CheckValue();
        }
        else
        {
            Spawner.spawnPlayer();
        }
    }


    public void lifeLost()
    {
        lives--;       
    }
}


