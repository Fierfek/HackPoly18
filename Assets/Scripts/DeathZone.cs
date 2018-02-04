using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathZone : MonoBehaviour {

	public float maxRadius, contractionRate, damageRate;
	ArrayList modules; 

	CircleCollider2D collider;

	// Use this for initialization
	void Start () {
		collider = GetComponent<CircleCollider2D>();
		collider.isTrigger = true;
		collider.radius = maxRadius;

		modules = new ArrayList();
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		collider.radius -= contractionRate * Time.fixedDeltaTime;

		if(modules.Count > 0) {
			foreach (Module m in modules) {
				m.TakeDamage(damageRate * Time.fixedDeltaTime);
			}
		}
	}

	void OnTriggerExit2D(Collider2D col) {
		if (col.gameObject.tag.Equals("Module")) {
			modules.Add(col.gameObject.GetComponent<Module>());
			
		}
	}

	void OnTriggerEnter2D(Collider2D col) {
		if (col.gameObject.tag.Equals("Module")) {
			modules.Remove(col.gameObject.GetComponent<Module>());
		}
	}
}
