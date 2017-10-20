using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

	public float m_movespeed = 1.0f;
	public float m_jumpforce = 10.0f;
	private bool m_onground = false;
	private float m_originaljumpforce;
	public GameObject groundcheck;
	private Rigidbody m_rb;

	private bool m_stoppedjumping = true;


	void Awake() {
		m_originaljumpforce = m_jumpforce;
		m_rb = gameObject.GetComponent<Rigidbody>();


	}


	// Use this for initialization
	void Update () {
		if(Input.GetAxis("Horizontal") != 0) {
			Vector3 pos = gameObject.transform.position;
			pos.x += Input.GetAxis("Horizontal") * m_movespeed * Time.deltaTime;
			gameObject.transform.position = pos;
		
		}

		if(Input.GetButtonDown("Jump") && m_onground) {
			m_onground = false;
			m_stoppedjumping = false;
			gameObject.GetComponent<Rigidbody>().AddForce(Vector3.up * m_jumpforce, ForceMode.Impulse);
		}

		if(Input.GetButtonUp("Jump") && !m_stoppedjumping) {
			if(m_rb.velocity.y > 0) {
				Vector3 velocity = m_rb.velocity;
				velocity.y = 0;
				m_rb.velocity = velocity;
			}
			m_stoppedjumping = true;
			m_jumpforce = m_originaljumpforce;
		}


	}

	void OnCollisionEnter(Collision other) {
		if(other.gameObject.tag == "Ground") {
			m_onground = true;
		} else {
			// ground check
		}
	}
}
	
