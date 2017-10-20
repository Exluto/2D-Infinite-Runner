using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FloorScript : MonoBehaviour {
	
	public GameObject theplatform;
	public Transform generatepoints;
	public float distancebetween;
	public float platformwidth;


	void Start() {

		platformwidth = GetComponent<BoxCollider>().size.x;
	}

	void Update() {

		if(transform.position.x < generatepoints.position.x) {

			transform.position = new Vector3(transform.position.x + platformwidth + distancebetween, transform.position.y, transform.position.z);

			Instantiate (theplatform, transform.position, transform.rotation);

		}


	}





	}
