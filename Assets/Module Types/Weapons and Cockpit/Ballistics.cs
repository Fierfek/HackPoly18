using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ballistics : Weapons {

    public float rateOfFire = .2f;
    public float timeToDisappear = .5f;
    float nextFire;
    public GameObject bulletPrefab;

    // Use this for initialization
    void Start()
    {


    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetButton("Fire1") && Time.time > nextFire)
        {
            nextFire = Time.time + 1/rateOfFire;
            Shoot();
        }

    }

    void Shoot()
    {
        GameObject bullet = (GameObject)Instantiate(bulletPrefab, transform.position + transform.forward, Quaternion.identity);

        Destroy(bullet, timeToDisappear);
    }
}
