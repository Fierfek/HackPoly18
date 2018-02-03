using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

	public float maxVelocity = 5;

	Rigidbody2D rigidbody;
	Vector2 moveDirection;

	// Use this for initialization
	void Start () {
		rigidbody = GetComponent<Rigidbody2D>();

		rigidbody.gravityScale = 0;
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		moveDirection.Set(Input.GetAxis("Horizontal")	, Input.GetAxis("Vertical"));


		moveDirection = moveDirection.normalized;

		rigidbody.MovePosition(rigidbody.position + moveDirection * maxVelocity * Time.fixedDeltaTime);
	}
}
