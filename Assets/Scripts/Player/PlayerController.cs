using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

	public float maxVelocity = 5;
	public Camera playerCamera;
	
	Rigidbody2D rigidbody;
	Vector2 moveDirection, lookDirection, mouseWorldPosition;

	// Use this for initialization
	void Start () {
		rigidbody = GetComponent<Rigidbody2D>();

		rigidbody.gravityScale = 0;
	}
	
	// Update is called once per frame
	void FixedUpdate () {

		//Rotate to mouse
		mouseWorldPosition = playerCamera.ScreenToWorldPoint(Input.mousePosition);
		lookDirection = (mouseWorldPosition - (Vector2)rigidbody.position).normalized;
		transform.up = lookDirection;
        playerCamera.transform.rotation = Quaternion.Euler(0, 0, 0);

        moveDirection.Set(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"));
		//move
		moveDirection = moveDirection.normalized;
		rigidbody.MovePosition(rigidbody.position + moveDirection * maxVelocity * Time.fixedDeltaTime);
	}
}
