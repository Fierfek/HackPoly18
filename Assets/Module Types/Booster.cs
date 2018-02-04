using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Booster : Module {

    public float healthAmount;
    public float boostAmount = 2;


	// Use this for initialization
	void Start () {
        health = healthAmount;
	}

	public float getBoost() {
		return boostAmount;
	}
}
