using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour {

	public Text m_ScoreUIText;

	private float m_score;

	// Use this for initialization
	void Start () {
		m_score = 0f;
		
	}
	
	// Update is called once per frame
	void Update () {
		m_score += Time.deltaTime;
		m_ScoreUIText.text =  " Score; " + (int)Mathf.Floor(m_score);
		
		
	}

	public void AddBonus(int pointsToAdd) {
		m_score += pointsToAdd;
	}
}
