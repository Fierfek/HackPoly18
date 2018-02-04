using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Laser : Weapons {

	public float rateOfFire;
	private float lastFire;
    public GameObject laserPrefab;
	private GameObject laser;

	// Use this for initialization
	void Start() {
		lastFire = 0;
	}

	public void Fire() {
		base.Fire_Trigger();
		if(Time.time + rateOfFire > lastFire) {
			lastFire = Time.time;
			laser = Instantiate(laserPrefab);

			laser.transform.position = transform.position;
			laser.transform.rotation = transform.rotation;
		}
	}
}
