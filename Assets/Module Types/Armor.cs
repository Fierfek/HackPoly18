using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Armor: Module {

    public float armorAmount;

	// Use this for initialization
	void Start () {
        health = armorAmount;
	}
}
