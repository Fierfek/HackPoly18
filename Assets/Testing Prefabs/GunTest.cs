using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunTest : MonoBehaviour {


    public float rateOfFire = .2f;
    public float timeToDisappear = .5f;
    public float nextFire;

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
            nextFire = Time.time + rateOfFire;
            Shoot();
        }

    }

    void Shoot()
    {
        GameObject bullet = (GameObject)Instantiate(bulletPrefab, transform.position + transform.forward, Quaternion.identity);

        Destroy(bullet, timeToDisappear);
    }
}
