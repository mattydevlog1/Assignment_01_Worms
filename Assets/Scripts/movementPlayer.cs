using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using System.Data.SqlTypes;
using Unity.VisualScripting.InputSystem;
using UnityEngine;
using UnityEngine.InputSystem;



public class movementPlayer : MonoBehaviour
{
    [SerializeField]
    float movementSpeed = 5f;
    [SerializeField]
    float jumpHeight = 10f;
    [SerializeField]
    GameObject player;

    bool canJump;

    public LayerMask Ground;

    public Rigidbody rb;

    bool isHit;


    Vector3 inputVector;


    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {


        //Movement input
        if (Input.GetKey(KeyCode.D))
        {
            rb.velocity = transform.right * movementSpeed;
        }
        if (Input.GetKey(KeyCode.A))
        {
            rb.velocity = -transform.right * movementSpeed;
        }
        if (Input.GetKey(KeyCode.W) && isHit)
        {
            rb.velocity = transform.forward * movementSpeed;
        }
        if (Input.GetKey(KeyCode.S))
        {
            rb.velocity = -transform.forward * movementSpeed;
        }

        // Check if player can jump or not
        RaycastHit hit;
        if ((Physics.Raycast(transform.position, transform.TransformDirection(Vector3.down), out hit,1f, Ground)))
        {

            isHit = true;
            canJump = true;

        }
        if ((canJump && isHit && Input.GetKeyDown("space")))
        {
            rb.AddForce(Vector2.up * jumpHeight);
            isHit = false;
        }
    }
}









