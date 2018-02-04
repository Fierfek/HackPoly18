using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class Missile : MonoBehaviour {

    public Transform target;
    public float velocity = 5f;
    public float rotateSpeed = 200f;
	public float missleDamage = 5f;

    private Rigidbody2D rb;
	// Use this for initialization
	void Start () {
        rb = GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	void FixedUpdate () {
        Vector2 direction = (Vector2)target.position - rb.position;

        direction.Normalize();

        float rotateAmount = Vector3.Cross(direction, transform.up).z;

        rb.angularVelocity = -rotateAmount * rotateSpeed;

        rb.velocity = transform.up * velocity;
	}

	private void OnTriggerEnter2D(Collider2D col) {
		if (col.tag.Equals("Player")) {
			if (!(col.gameObject.GetComponentInParent<ModuleManager>().playerID == GetComponent<Projectile>().playerID)) {
				col.gameObject.GetComponent<Module>().TakeDamage(missleDamage);
			}
		} else {
			Destroy(this);
		}
	}
}
