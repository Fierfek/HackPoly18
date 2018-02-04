using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

	public float baseVelocity = 5, boostVelocity = 0, angularVelocity = 90;
	public Camera playerCamera;

	Rigidbody2D rigidbody;
	Vector2 moveDirection, lookDirection, mouseWorldPosition;

	// Use this for initialization
	void Awake () {
		rigidbody = GetComponent<Rigidbody2D>();
		rigidbody.gravityScale = 0;

        playerCamera.transform.localPosition = new Vector3(0, 0, -5);
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		//Rotate to mouse
		mouseWorldPosition = playerCamera.ScreenToWorldPoint(Input.mousePosition);
		lookDirection = (mouseWorldPosition - (Vector2)rigidbody.position).normalized;
		Vector2 forward = new Vector2(Mathf.Sin(-transform.rotation.eulerAngles.z * Mathf.Deg2Rad), Mathf.Cos(-transform.rotation.eulerAngles.z * Mathf.Deg2Rad));

		float delta = Vector2.SignedAngle(forward, lookDirection);

		if(delta > 3) {
			rigidbody.angularVelocity = angularVelocity;
		} else if (delta < -3) {
			rigidbody.angularVelocity = -angularVelocity;
		} else {
			transform.up = lookDirection;
		}

		playerCamera.transform.rotation = Quaternion.Euler(0, 0, 0);

		//move
		moveDirection.Set(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"));

		moveDirection = moveDirection.normalized;
		rigidbody.MovePosition(rigidbody.position + moveDirection * (baseVelocity + boostVelocity) * Time.fixedDeltaTime);
		boostVelocity = 0;
	}
}
