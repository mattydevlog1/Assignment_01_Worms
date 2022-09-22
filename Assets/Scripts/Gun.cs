using System.Collections;
using System.Collections.Generic;
using System.Threading;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.AI;
using static System.Runtime.CompilerServices.RuntimeHelpers;

public class Gun : MonoBehaviour
{
    [SerializeField]
    public Rigidbody projectile;

    [SerializeField]
    Transform spawnPoint;

    public ParticleSystem muzzle;

    public float fireRate = 0.5f;
    private float nextFire = 0.0f;





    void Update()
    {



        if (Input.GetKey("mouse 0") && Time.time > nextFire)
        {
            nextFire = Time.time + fireRate;

            Rigidbody clone;
            clone = Instantiate(projectile, spawnPoint.position, spawnPoint.rotation);
            clone.AddForce(spawnPoint.forward * 100, ForceMode.VelocityChange);


            Instantiate(muzzle, spawnPoint.position, spawnPoint.rotation);
            muzzle.Play();

        }


    }


}

