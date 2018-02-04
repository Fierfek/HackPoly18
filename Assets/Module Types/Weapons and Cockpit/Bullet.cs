using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour {

    public float bulletDamage = 3f, velocity = 50f;
    float countdown;
    bool hasVaporized;

    Rigidbody2D bulletRigidbody;

	// Use this for initialization
	void Start () {
        bulletRigidbody = GetComponent<Rigidbody2D>();
	}

    // Update is called once per frame
    void FixedUpdate()
    {
        bulletRigidbody.MovePosition(transform.position + transform.up * velocity * Time.fixedDeltaTime);
    }

    private void OnTriggerEnter2D(Collider2D col)
    {	
		if(col.tag.Equals("Player")) {
			if (!(col.gameObject.GetComponentInParent<PlayerController>().playerID == GetComponent<Projectile>().playerID)) {
				col.gameObject.GetComponent<Module>().TakeDamage(bulletDamage);
			}
		} else {
			Destroy(this);
		}
	}
}
