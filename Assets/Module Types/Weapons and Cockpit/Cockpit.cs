using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cockpit : Weapons {


    public float damageAmount = 1f;
    public float rateOfFire;
    public GameObject bulletPrefab;

    // Use this for initialization
    void Start()
    {


    }

    // Update is called once per frame
    void Update()
    {

        if (health <= 0)
        {
            //Destroy Module and create empty space
        }

    }


}
