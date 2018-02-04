using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Module : MonoBehaviour {

	private PolygonCollider2D collider;
	protected float health;
	PlayerController player;

	void Start() {
		player = GetComponentInParent<PlayerController>();
	}

	public void TakeDamage(float amount) {
        health -= amount;

		if(health < 1) {
			Die();
		}
	}

	protected void AttachToShip() {
		player.addModule(this);
	}

	protected void Die() {
		player.destroyModule(this);
	}
}
