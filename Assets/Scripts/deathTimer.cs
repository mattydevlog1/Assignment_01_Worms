using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class deathTimer : MonoBehaviour
{
    public GameObject projectile;
    public float destroyTime = 5f;
    // Start is called before the first frame update
    void Start()
    {
        Destroy(projectile, destroyTime);
    }


}
