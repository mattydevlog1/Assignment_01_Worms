using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEditor;
using UnityEngine;



public class cameraSwitch : MonoBehaviour
{
    public Camera player1Cam;
    public Camera player2Cam;




    private void Start()
    {

        player1Cam.enabled = true;
        Gamemanager.Instance.turnTimer = 10;
    }


    void Update()
    {
        Gamemanager.Instance.turnTimer -= Time.deltaTime;



        if (Gamemanager.Instance.turnTimer < 0 && player1Cam.enabled)
        {
            player1Cam.enabled = false;
            player2Cam.enabled = true;
            Gamemanager.Instance.turnTimer = 10;


        }
        if (Gamemanager.Instance.turnTimer < 0 && player2Cam.enabled)
        {
            player1Cam.enabled = true;
            player2Cam.enabled = false;
            Gamemanager.Instance.turnTimer = 10;


        }
       // Debug.Log(Gamemanager.Instance.turnTimer);
    }
}
