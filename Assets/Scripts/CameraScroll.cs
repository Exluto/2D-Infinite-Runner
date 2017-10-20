using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraScroll : MonoBehaviour {

	public float m_movespeed = 1.0f;


	// Update is called once per frame
	void Update () {
		Vector3 pos = gameObject.transform.position;
		pos.x = m_movespeed * GameManager.Instance.GameSpeed * Time.deltaTime;
		gameObject.transform.position = pos;
		
	}
}
