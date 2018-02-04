using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MissileLauncher : Weapons {


    public float damageAmount = 1f;
    public float rateOfFire = .5f;
    public float timeToDisappear = 3f;
    float nextFire;
    public GameObject missilePrefab;

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
        GameObject bullet = (GameObject)Instantiate(missilePrefab, transform.position + transform.forward, Quaternion.identity);

        Destroy(bullet, timeToDisappear);
    }
}
