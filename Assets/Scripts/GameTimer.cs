using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameTimer : MonoBehaviour {

	public float StartTime;
	public float TimeRemaining;
	bool GameWon;
	GameObject victory;
	GameObject[] destructible;
	float StartLvl; 


	// Use this for initialization
	void Start () {
		GameWon = false; 
		victory = GameObject.Find("Victory"); 
		victory.SetActive(false);
	}
	
	// Update is called once per frame
	void Update ()
	{
		gameObject.GetComponent<Slider> ().value = Time.timeSinceLevelLoad / StartTime;


		if (!GameWon) { // this prevents the win condition from being called more than once during update. Use a bool to do this!
			if (gameObject.GetComponent<Slider> ().value >= 1f) {
				destructible = GameObject.FindGameObjectsWithTag ("Destroy");
				gameObject.GetComponent<AudioSource> ().Play ();
				GameWon = true; // have to set the bool to true to ensure it doesn't run code twice
				foreach (GameObject obj in destructible) { // this destroys all objects with the desired tag
					Destroy (obj); } 
				victory.SetActive (true); // enables the "victory" text box
				Invoke ("Win", 3f); // gives the audio time to finish playing before level load
			}
		}
	}

	void Win() {
		int nextSceneIndex = SceneManager.GetActiveScene().buildIndex +1;
		SceneManager.LoadScene(nextSceneIndex); 
	}
	// These lines allow you to check if a level up occured during the current level and take you to a level up screen if so. Was not implemented due to no level selection in this game.
	//StartLvl = LevelStat.Level; 
	//float CurrentLevel = LevelStat.Level; 
	//if (CurrentLevel > StartLvl) {
	//if (CurrentLevel == StartLvl) {
	//SceneManager.LoadScene("LevelUp");
}
