using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Armor: Module {

    public float armorAmount;

	// Use this for initialization
	void Start () {
        health = armorAmount;

	}
	
	// Update is called once per frame
	void Update () {
		if(health <= 0)
        {
            //Destroy Module and create empty space
        }
	}
}
