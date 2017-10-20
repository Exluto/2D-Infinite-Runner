using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Creator : MonoBehaviour {

	void OnTriggerExit(Collider other) {
		if(other.tag == "Ground") {
			GameManager.Instance.AddNewSections();
		}


	}
}
