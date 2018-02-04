using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Module : MonoBehaviour {

	public PolygonCollider2D modSpot;
	protected float health;

	protected void TakeDamage(float amount) {
        health -= amount;
	}

	void OnTriggerEnter2D(Collider2D col) {

	}
}
