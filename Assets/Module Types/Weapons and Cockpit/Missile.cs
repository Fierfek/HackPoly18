﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Missile : Weapons {


    public float damageAmount = 1f;
    public float rateOfFire;
    public GameObject missilePrefab;

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