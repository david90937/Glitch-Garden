using UnityEngine;
using System.Collections;

public class Defender : MonoBehaviour {
	public StarDisplay starDisplay;
	public int StarCost;
	// Use this for initialization
	void Start () {
		starDisplay = GameObject.FindObjectOfType<StarDisplay>();
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void AddStars (int amount) {
		starDisplay.AddStars(amount);
	}
}
