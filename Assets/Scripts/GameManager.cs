using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour {

	public float m_speedIR;

	public Text m_ScoreUIText;

	//private float m_score;
	private float m_gameSpeed;
	public GameObject[] m_prefabSections;
	public float[] m_prefabsectionsLength;
	private int m_numprefabs;
	private int m_currentPrefab = 1;

	private float m_currentPrefabPos = 0;

	public float GameSpeed{ get{return m_gameSpeed; } }

	private static GameManager m_instance = null;

	public static GameManager Instance { get { return m_instance; } }

	void Awake() {
		if(m_instance != null && m_instance != this) {
			Destroy(this.gameObject);
			return;
		} else {
			m_instance = this;
		}

		DontDestroyOnLoad(this.gameObject);

		m_numprefabs = m_prefabSections.Length;
		}

	// Use this for initialization
	void Start () {
		m_speedIR = 0.1f;
		m_score = 0f;
		m_gameSpeed = 1;

		CreateSection(0);
		CreateSection(1);
		
	}
	
	// Update is called once per frame
	void Update () {
		m_gameSpeed += m_speedIR * Time.deltaTime;
		m_score += Time.deltaTime;
		m_ScoreUIText.text =  " Score; " + (int)Mathf.Floor(m_score);
		
		
	}

	public void AddNewSections() {
		CreateSection(2);

	}

	private void CreateSection(int s) {

		Vector3 pos = Vector3.zero;
		pos.x = m_prefabsectionsLength[m_currentPrefab] + m_currentPrefabPos;

		GameObject tmp = Instantiate(m_prefabSections[s], pos, Quaternion.identity);
		tmp.name = "Selection - " + s;
		m_currentPrefab = s;
		m_currentPrefabPos = pos.x;
	}
	public void AddBonus(int pointsToAdd) {
		m_score += pointsToAdd;
	}

	public void RestartLevel() {
		m_gameSpeed = 1;
		m_score = 0;
	}

	public void ResetSpeed() {
		m_gameSpeed = 1;
	}

	public int GetScore() {
		return (int)Mathf.Floor(m_score);
	}

}
