using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Light_Script : MonoBehaviour
{
    public GameObject pointlight1;
    public GameObject pointlight2;
    public GameObject pointlight3;
    public GameObject pointlight4;
    public GameObject pointlight5;
    public GameObject pointlight6;
    public GameObject pointlight7;
    public void pl1()
    {
        pointlight1.GetComponent<Light>().enabled = true;
    }
    public void pl2()
    {
        pointlight2.GetComponent<Light>().enabled = true;
    }
    public void pl3()
    {
        pointlight3.GetComponent<Light>().enabled = true;
    }
    public void pl4()
    {
        pointlight4.GetComponent<Light>().enabled = true;
    }
    public void pl5()
    {
        pointlight5.GetComponent<Light>().enabled = true;
    }
    public void pl6()
    {
        pointlight6.GetComponent<Light>().enabled = true;
    }
    public void pl7()
    {
        pointlight7.GetComponent<Light>().enabled = true;
    }
}
