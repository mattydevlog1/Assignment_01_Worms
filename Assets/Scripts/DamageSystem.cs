using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.UIElements;


public class DamageSystem : MonoBehaviour
{
    public GameObject enemy;

    [SerializeField]
    float maxHP;

    float currentHp;
    [SerializeField]
    int projectileDamage = 10;

    float damageTaken;
    float timesHit;



    void Start()
    {
        maxHP = 100;
        currentHp = maxHP;
    }


    void OnTriggerEnter(Collider other)
    {
        if (Gamemanager.Instance.currentPlayer == Gamemanager.Instance.playerOne)
        {
            Hit();

        }




        void Hit()
        {

            if (currentHp > 0)
            {
                timesHit++;
                damageTaken = projectileDamage * timesHit;
                dmg();
            }
            else if (currentHp <= 0)
            {
                dmg2();
            }

        }
    }
    void dmg()

    {
        //  timesHit++;
        currentHp = maxHP - damageTaken;
        Debug.Log(currentHp);


    }

    void dmg2()
    {

        {
            Destroy(enemy);

            Debug.Log("target is dead");

        }

    }
}
