using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class HealthDisplay : MonoBehaviour {
	public Text text;
	GameObject health;
	// Use this for initialization
	void Start () {
		health = GameObject.Find("Lose Collider");
	}
	
	// Update is called once per frame
	void Update () {
		text.text = health.GetComponent<LoseCondition>().LevelHealth.ToString();
	}
}
