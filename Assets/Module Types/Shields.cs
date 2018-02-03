using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shields : Module {

    public float timer = 0;
    public float healthAmount;
    public float shieldAmount;
    public float shieldCapacity;
    public float rechargeRate;
    public int damageCooldown;
    bool wasDamaged = false;
    
 

	// Use this for initialization
	void Start () {
        health = healthAmount;
        shieldAmount = shieldCapacity;
	}
	
	// Update is called once per frame
	void Update () {

        if (health <= 0)
        {
            //Destroy Module and create empty space
        }

        if(wasDamaged == false && shieldAmount < shieldCapacity)
        {
            wasDamaged = true;
        }

        if (wasDamaged)
        {
            timer = Time.deltaTime;
            if (timer == damageCooldown)
            {
                wasDamaged = false;
                
            }
        }


	}

    void RechargeShield()
    {

    }
}
