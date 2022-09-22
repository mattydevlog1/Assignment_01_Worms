using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraMovement : MonoBehaviour
{
    private float x;
    private float y;
    float sensitivity = -1f;
    Vector3 rotate;



    // Locking cursor
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }

    // Rotating cursor + player with movement of mouse
    void Update()
    {
        y = Input.GetAxis("Mouse X");
        x = Input.GetAxis("Mouse Y");

        if (Gamemanager.Instance.turnTimer >= 0)
        {
            rotate = new Vector3(x, y * sensitivity, 0);
            transform.eulerAngles = transform.eulerAngles - rotate;

        }

    }
}
