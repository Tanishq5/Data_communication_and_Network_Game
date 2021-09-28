using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Button_Script : MonoBehaviour
{
    public GameObject Q1;
    public GameObject Q2;
    public GameObject Q3;
    public GameObject Q4;
    public GameObject Q5;
    public GameObject Q6;
    public GameObject Q7;
    public player_Script PlayerMovement;
    public Text lives;
    public int LivesCounter = 2;

    public void DisableQuestion()
    {
        Q1.SetActive(false);
        Q2.SetActive(false);
        Q3.SetActive(false);
        Q4.SetActive(false);
        Q5.SetActive(false);
        Q6.SetActive(false);
        Q7.SetActive(false);
    }
    public void EnablePlayerMovement()
    {
        PlayerMovement.enabled = true;
    }
    public void Lives()
    {
        LivesCounter--;
        lives.text = ": " + LivesCounter;

        if(LivesCounter < 0)
        {
            SceneManager.LoadScene("Main");
        }
    }
    public void RestartLevel()
    {
        SceneManager.LoadScene("Main");
    }
}
