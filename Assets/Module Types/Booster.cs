using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Booster : Module {

    public float healthAmount;
    public float boostAmount;
    public float boostMax;


	// Use this for initialization
	void Start () {
        health = healthAmount;
	}
	
	// Update is called once per frame
	void Update () {
        if (health <= 0)
        {
            //Destroy Module and create empty space
        }
        //adds to maximum speed.
        
    }
}
