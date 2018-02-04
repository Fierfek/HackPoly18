﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Module : MonoBehaviour {

	private BoxCollider2D collider;
	public float health;
	private float initialHealth;
	protected ModuleManager player;

	void Start() {
		player = GetComponentInParent<ModuleManager>();

		if(this is Cockpit) {
			gameObject.SetActive(true);
		}

		initialHealth = health;

		if(player != null) {
			player.addModule(this);
		}
	}

	public void TakeDamage(float amount) {
        health -= amount;

		Debug.Log("hit");

		if(health < 1) {
			Die();
		}
	}

	public void SetArmorBonus(bool flag) {

	}

	public void AttachToShip(Module mod) {
		player.addModule(mod);
		mod.player = this.player;
	}

	protected void Die() {
		player.destroyModule(this);
	}

	void OnTriggerEnter2D (Collider2D col) {
		if (col.name.Equals("Model")) {
			Debug.Log(this.gameObject.name);
			Destroy(GetComponent<Rigidbody2D>());
			col.gameObject.GetComponentInParent<Module>().AttachToShip(this);
		}
	}
}
