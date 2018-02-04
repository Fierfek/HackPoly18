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
        Debug.Log("Running");
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        
    }
}
