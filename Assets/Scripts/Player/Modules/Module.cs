using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Module : MonoBehaviour {

	private BoxCollider2D collider;

    [SerializeField] private float initialHealth = 20;
    public float health;

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

		if(health <= 0) {
			Die();
		}
	}

	public void SetArmorBonus(bool flag) {

	}

	public void AttachToShip(Module mod) {
		if(mod != null) {
			player.addModule(mod);
			mod.player = this.player;
		}
	}

	protected void Die() {
		if(this != null) 
			player.destroyModule(this);
	}

	void OnTriggerEnter2D (Collider2D col) {
		if (col.name.Equals("Model")) {
			Destroy(GetComponent<Rigidbody2D>());
			col.gameObject.GetComponentInParent<Module>().AttachToShip(this);
		}
	}
}
