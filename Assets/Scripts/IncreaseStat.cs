using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class IncreaseStat : MonoBehaviour {
	public Text text;
	public Text FPtext;
	public static int FreePoints;
	float intelligence;
	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update ()
	{
		intelligence = PlayerPrefManager.GetIntelligence (); 
		text.text = intelligence.ToString (); 
		print (intelligence);
		FPtext.text = "You have " + (FreePoints / 5).ToString () + " points available.";
		if (FreePoints <= 0) {
			GameObject.Find ("Intelligence").SetActive (false);
		}
	}

	public void increaseStat ()
	{
		PlayerPrefManager.SetIntelligence (intelligence + 5);
		FreePoints = FreePoints - 5;
		print (FreePoints);
	}
}
