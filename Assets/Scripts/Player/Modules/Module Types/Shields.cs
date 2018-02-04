using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shields : Module {

    public float timer = 0;
    public float shieldAmount;
    public float shieldCapacity;
    public float rechargeRate;
    public int damageCooldown;
    bool wasDamaged = false;
	
	// Update is called once per frame
	void Update () {

        if(wasDamaged == false && shieldAmount < shieldCapacity)
        {
            RechargeShield(rechargeRate);
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

    void RechargeShield(float chargeAmount)
    {
        if(shieldAmount < shieldCapacity)
        {
            shieldAmount += rechargeRate * Time.deltaTime;
        }
        
    }
}
