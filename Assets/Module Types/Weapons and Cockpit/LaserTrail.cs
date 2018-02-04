using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaserTrail : MonoBehaviour {

    public int laserSpeed = 200;
    public float laserLife = 1f;
	// Update is called once per frame
	void Update () {
        transform.Translate(Vector3.left * Time.deltaTime * laserSpeed);
        Destroy(gameObject, laserLife);
	}
}
