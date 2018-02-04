using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

	public float baseVelocity = 5, velocity;
	public Camera playerCamera;

	ArrayList modules;
	bool fire;

	Rigidbody2D rigidbody;
	Vector2 moveDirection, lookDirection, mouseWorldPosition;

	// Use this for initialization
	void Start () {
		rigidbody = GetComponent<Rigidbody2D>();

		rigidbody.gravityScale = 0;

		modules = new ArrayList();
	}
	
	// Update is called once per frame
	void FixedUpdate () {

		//Rotate to mouse
		mouseWorldPosition = playerCamera.ScreenToWorldPoint(Input.mousePosition);
		lookDirection = (mouseWorldPosition - (Vector2)rigidbody.position).normalized;
		transform.up = lookDirection;
        mouseWorldPosition = playerCamera.ScreenToWorldPoint(Input.mousePosition);

        //move
        moveDirection.Set(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"));

		if(modules.Count > 0) {
			foreach(Module m in modules) {
				if(m is Booster) {
					Booster temp = (Booster) m;
					velocity += temp.getBoost();
				} else if((m is Weapons) && fire) {
					Weapons temp = (Weapons)m;
					temp.Fire();
				}
			}
		}

		moveDirection = moveDirection.normalized;
		rigidbody.MovePosition(rigidbody.position + moveDirection * (baseVelocity + velocity) * Time.fixedDeltaTime);
	}

	public void addModule(Module mod) {
		modules.Add(mod);
	}

	public void destroyModule(Module mod) {
		modules.Remove(mod);
	} 
}
