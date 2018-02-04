using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ballistics : Weapons {

    public float rateOfFire = .2f;
    public float timeToDisappear = 5f;
	private float lastFire = 0;
    float nextFire;
    public GameObject bulletPrefab;

	public override void Fire()
    {
		if(Time.time > lastFire + rateOfFire) {
			GameObject bullet = Instantiate(bulletPrefab, transform.position, transform.rotation);
			bullet.GetComponent<Projectile>().playerID = player.playerID;
			//Destroy(bullet, timeToDisappear);

			lastFire = Time.time;
		}
    }
}
