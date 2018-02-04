using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaserProjectile : MonoBehaviour {

	public float damage, distance = 100;
	bool done;

	GameObject linePrefab;
	RaycastHit2D hit;
	public LineRenderer line;

	// Use this for initialization
	void Start () {
		done = false;
		line = Instantiate(linePrefab).GetComponent<LineRenderer>();		
	}

	void FixedUpdate() {
		if(!done) {
			line.SetPosition(0, transform.position);

			hit = Physics2D.Raycast(transform.position, transform.forward, distance);

			if (hit.collider != null) {
				line.SetPosition(1, hit.point);
			} else {
				line.SetPosition(1, transform.position + (transform.forward * distance));
			}
		}
	}
}
