using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathZone : MonoBehaviour {

	public float maxRadius, contractionRate, damageRate;
	private float radius;
	ArrayList modules; 

	CircleCollider2D collider;

	// Use this for initialization
	void Start () {
		collider = GetComponent<CircleCollider2D>();
		collider.isTrigger = true;
		collider.radius = 3;
		modules = new ArrayList();
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		radius -= contractionRate * Time.fixedDeltaTime;
		if(transform.localScale.x > 0) { 
			transform.localScale = new Vector3(transform.localScale.x - contractionRate * Time.deltaTime, transform.localScale.y - contractionRate * Time.deltaTime, 1);
		}

		if(modules.Count > 0) {
			foreach (Module m in modules) {
				if(m != null) {
					m.TakeDamage(damageRate * Time.fixedDeltaTime);
				}
			}
		}
	}

	void OnTriggerExit2D(Collider2D col) {
		if (col.gameObject.tag.Equals("Module")) {
			modules.Add(col.gameObject.GetComponentInParent<Module>());
		}
	}

	void OnTriggerEnter2D(Collider2D col) {
		if (col.gameObject.tag.Equals("Module")) {
			modules.Remove(col.gameObject.GetComponentInParent<Module>());
		}
	}
}
