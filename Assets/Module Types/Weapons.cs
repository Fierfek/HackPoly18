using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapons : Module {

    public float healthAmount;
    public float damageAmount = 1f;
    public float rateOfFire;
    public enum WeaponType { Type1, Type2, Type3};
    public WeaponType BoomType;


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
        //if button is hit
        if (Input.GetButtonDown("Space"))
        {
            Fire();
        }
	}

    void Fire()
    {
        //Blam Blam!
    }
}
