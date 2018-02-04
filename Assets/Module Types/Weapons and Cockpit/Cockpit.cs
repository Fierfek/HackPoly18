using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cockpit : Weapons {

    public float rateOfFire = .2f;
    public float timeToDisappear = .5f;
    public GameObject bulletPrefab;
	private float lastFire = 0;

	public override void Fire() {
		if (Time.time > lastFire + rateOfFire) {
			GameObject bullet = Instantiate(bulletPrefab, transform.position + transform.forward, transform.rotation);
			bullet.GetComponent<Projectile>().playerID = player.playerID;

			Destroy(bullet, timeToDisappear);
			lastFire = Time.time;
		}
	}
}
