using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MissileLauncher : Weapons {


    public float damageAmount = 1f;
    public float rateOfFire = .5f;
    public float timeToDisappear = 3f;
    float lastFire;
    public GameObject missilePrefab;

    public override void Fire()
    {
		if (Time.time > lastFire + rateOfFire) {
			GameObject bullet = Instantiate(missilePrefab, transform.position, transform.rotation);

			Destroy(bullet, timeToDisappear);

			lastFire = Time.time;
		}
    }
}
