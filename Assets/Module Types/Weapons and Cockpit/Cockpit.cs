using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cockpit : Weapons {

    public float bulletVelocity = 3f;
    public float rateOfFire;
    public float timeToDisappear = 4f;
    public GameObject bulletPrefab;
    public Transform bulletSpawn;

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

    void Shoot()
    {
        var bullet = (GameObject)Instantiate(bulletPrefab, bulletSpawn.position, Quaternion.identity);

        bullet.GetComponent<Rigidbody2D>().velocity = bullet.transform.forward * bulletVelocity;

        Destroy(bullet, timeToDisappear);
    }
}
