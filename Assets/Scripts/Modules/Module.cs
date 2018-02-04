using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Module : MonoBehaviour {

	private PolygonCollider2D collider;
	public float health;
	private float initialHealth;
	protected ModuleManager player;

	void Start() {
		player = GetComponentInParent<ModuleManager>();

		initialHealth = health;

		if(player != null) {
			Debug.Log(this.gameObject.name);
			player.addModule(this);
		}
	}

	public void TakeDamage(float amount) {
        health -= amount;

		if(health < 1) {
			Die();
		}
	}

	public void SetArmorBonus(bool flag) {

	}

	protected void AttachToShip() {
		player.addModule(this);
	}

	protected void Die() {
		player.destroyModule(this);
	}
}
