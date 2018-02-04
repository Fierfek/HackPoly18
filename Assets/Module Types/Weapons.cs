using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapons : Module {

    public float healthAmount;
    public float damageAmount = 1f;
    public float rateOfFire;
    public enum WeaponType { Type1, Type2, Type3};
    public WeaponType BoomType;
    public GameObject projectile1, projectile2, projectile3;


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
        if (Input.GetButtonDown("Fire Button"))
        {
            Fire();
        }
	}

    void Fire()
    {
        //Instantiate(projectile, transform.position);
        //Blam Blam with BoomType
        if(BoomType == WeaponType.Type1)
        {
            //Shoot projectile 1 Ballistics
        }
        else if (BoomType == WeaponType.Type2)
        {
            //Shoot projectile 2 Lasers
        }
        else if (BoomType == WeaponType.Type3)
        {
            //Shoot projectile 3 Missiles
        }

    }
}
