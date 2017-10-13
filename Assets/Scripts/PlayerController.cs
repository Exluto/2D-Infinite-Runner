using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

	public float speed;


	// Use this for initialization
	void Update () {
		var x = Input.GetAxis("Horizontal") * Time.deltaTime * 250f;
		var z = Input.GetAxis("Vertical") * Time.deltaTime * 20f;

		transform.Rotate(0, x, 0);
		transform.Translate(0, 0, z);
		
	}
}
	
