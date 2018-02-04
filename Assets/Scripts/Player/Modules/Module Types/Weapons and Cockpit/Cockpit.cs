using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cockpit : Weapons
{
    public float rateOfFire = .2f;
    public GameObject bulletPrefab;
    private float lastFire = 0;

    private ModuleManager moduleManager;

    private void Awake()
    {
        moduleManager = GetComponentInParent<ModuleManager>();
    }


    public override void Fire_Trigger()
    {
        if (Time.time > lastFire + rateOfFire)
        {
            Fire();

            lastFire = Time.time;
        }
    }

    public void Fire()
    {
        GameObject bullet = PhotonNetwork.Instantiate(bulletPrefab.name, transform.position + transform.forward, transform.rotation, 0);
        bullet.GetComponent<Projectile>().playerID = moduleManager.playerID;
    }

    public void LateUpdate()
    {
        if(health <= 0)
        {
            Debug.Log("I am dead!!!");
            // NOTE: Do Game Over Stuff Here
        }
    }
}
