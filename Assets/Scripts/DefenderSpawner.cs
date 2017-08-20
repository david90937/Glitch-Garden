using UnityEngine;
using System.Collections;

public class DefenderSpawner : MonoBehaviour {
	StarDisplay stars;
	Defender defender;
	// Use this for initialization
	void Start () {
		stars = GameObject.Find("Stars").GetComponent<StarDisplay>();

	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnMouseDown ()
	{
		GameObject defender = Button.SelectedDefender;
		int defenderCost = defender.GetComponent<Defender>().StarCost;

		if (defenderCost <= StarDisplay.stars) {
			SpawnDefender ();
			stars.UseStars(defenderCost); }  
	}

	Vector3 CalculateWorldPointOfMouseClick ()
	{
		Vector3 rawWorldPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
		return rawWorldPos; 
	}

	Vector3 SnapToGrid (Vector3 rawWorldPos) {
		int newX = Mathf.RoundToInt(rawWorldPos.x);
		int newY = Mathf.RoundToInt(rawWorldPos.y);
		return new Vector3 (newX, newY, 0f);
	}

	void SpawnDefender() {
		GameObject SpawnDefender = Instantiate(Button.SelectedDefender); 
		SpawnDefender.transform.position = (SnapToGrid(CalculateWorldPointOfMouseClick()));

	}
}
