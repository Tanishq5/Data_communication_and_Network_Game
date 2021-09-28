using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Swicth : MonoBehaviour
{
    private GameObject player;
    private float distance;
    public Text text;
    public GameObject spotlight;
    public GameObject RestartButton;
    public GameObject PointLights;
    private void Awake()
    {
        player = GameObject.Find("Player");
    }
    void Update()
    {
        distance = Vector3.Distance(player.transform.position, this.transform.position);

        if (distance < 3)
        {
            text.enabled = true;
            if (Input.GetKey(KeyCode.E))
            {
                text.enabled = false;
                PointLights.SetActive(false);
                spotlight.SetActive(true);
                RestartButton.SetActive(true);
            }
        }
        else if(distance > 3)
        {
            text.enabled = false;
        }
    }
}
