using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Follow : MonoBehaviour {

	public Transform playersTransform;
	
	// Update is called once per frame
	void Update () {
		transform.position = playersTransform.position;
	}
}
