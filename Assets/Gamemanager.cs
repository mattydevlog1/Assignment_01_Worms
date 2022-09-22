using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor;
using UnityEngine;

public class Gamemanager : MonoBehaviour
{
    public static Gamemanager Instance;


    [SerializeField] public movementPlayer playerOne;
    [SerializeField] public movementPlayer playerTwo;
    [SerializeField] public float turnTimer;


    public bool isActive;
 
    public movementPlayer currentPlayer;



    private void Start()
    {


    }

    void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            currentPlayer = playerOne;


        }
    }
    private void Update()
    {

        if (turnTimer == 0)
        {
            ChangeTurn();
        }



    }


    private void ChangeTurn()
    {
        if (playerOne == currentPlayer)
        {
            currentPlayer = playerTwo;


        }
        if (playerTwo == currentPlayer && !currentPlayer == playerOne)
        {
            currentPlayer = playerOne;
           
        }
    }



}
