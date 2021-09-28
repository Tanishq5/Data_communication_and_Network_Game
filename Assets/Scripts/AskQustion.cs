using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AskQustion : MonoBehaviour
{
    public GameObject Q1;
    public GameObject Q2;
    public GameObject Q3;
    public GameObject Q4;
    public GameObject Q5;
    public GameObject Q6;
    public GameObject Q7;
    private int q1 = 1;
    private int q2 = 1;
    private int q3 = 1;
    private int q4 = 1;
    private int q5 = 1;
    private int q6 = 1;
    private int q7 = 1;
    public Text WhiteLight;
    public player_Script PlayerMovement;
    private void OnTriggerEnter(Collider T)
    {
        if (T.gameObject.tag == "Q1")
        {
            WhiteLight.enabled = false;
            if(q1 == 1)
            {
                Q1.SetActive(true);
                PlayerMovement.enabled = false;
                q1--;
            }
        }
        else if(T.gameObject.tag == "Q2")
        {
            if (q2 == 1)
            {
                Q2.SetActive(true);
                PlayerMovement.enabled = false;
                q2--;
            }
        }
        else if (T.gameObject.tag == "Q3")
        {
            if (q3 == 1)
            {
                Q3.SetActive(true);
                PlayerMovement.enabled = false;
                q3--;
            }
        }
        else if (T.gameObject.tag == "Q4")
        {
            if (q4 == 1)
            {   
                Q4.SetActive(true);
                PlayerMovement.enabled = false;
                q4--;
            }
        }
        else if (T.gameObject.tag == "Q5")
        {
            if (q5 == 1)
            {   
                Q5.SetActive(true);
                PlayerMovement.enabled = false;
                q5--;
            }
        }
        else if (T.gameObject.tag == "Q6")
        {
            if (q6 == 1)
            { 
                Q6.SetActive(true);
                PlayerMovement.enabled = false;
                q6--;
            }
        }
        else if (T.gameObject.tag == "Q7")
        {
            if (q7 == 1)
            {
                Q7.SetActive(true);
                PlayerMovement.enabled = false;
                q7--;
            }
        }
    }
}

