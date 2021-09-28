using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class player_Script : MonoBehaviour
{
    public GameObject Switch;
    [SerializeField] float Speed = 10f;
    float RotSpeed = 5f;
    private float distance;

    private void Awake()
    {
        Switch = GameObject.Find("SwitchBox");
    }

    void Update()
    {
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");
        float mousex = Input.GetAxis("Mouse X");

        Vector3 MoveRight = Vector3.right * Speed * h;
        Vector3 MoveForward = Vector3.forward * Speed * v;
        Vector3 Movement = (MoveRight + MoveForward).normalized * Speed * Time.deltaTime;

        transform.Translate(Movement);
        transform.Rotate(Vector3.up * RotSpeed * mousex);

        NormalSpeed();

    }
    private void OnTriggerEnter(Collider Tr)
    {
        if (Tr.gameObject.tag == "SlowFloor")
        {
            Speed = 5;
        }
        
    }
    public void NormalSpeed()
    {
        distance = Vector3.Distance(Switch.transform.position, this.transform.position);

        if (distance < 3)
        {
            if (Input.GetKey(KeyCode.E))
            {
                Speed = 20;
            }
        }
    }
}
