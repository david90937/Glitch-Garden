using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class LevelStat : MonoBehaviour {
	public static float Level; 
	float TilNextLvl;
	float XP;
	float ExpDiff;
	float NextLvl2;

	// Use this for initialization
	void Start () {
		PlayerPrefManager.SetExperience(0f);
		PlayerPrefManager.SetIntelligence(0f);
		float XP = PlayerPrefManager.GetExperience();
		Level = Mathf.FloorToInt(0.6f * Mathf.Sqrt(XP));
		NextLvl2 = (((Level + 1) * (Level + 1)) / (0.6f * 0.6f));

	}
	
	// Update is called once per frame
	void Update () {
		LevelExperience();

	}


	public void LevelExperience ()
	{
		float XP = PlayerPrefManager.GetExperience ();
		Level = Mathf.FloorToInt (0.6f * Mathf.Sqrt (XP)); 
		float TilNextLvl = (((Level + 1) * (Level + 1)) / (0.6f * 0.6f)) - PlayerPrefManager.GetExperience ();
		float NextLvl = (((Level + 1) * (Level + 1)) / (0.6f * 0.6f));
		float CurrentLvl = Level * Level / 0.36f;
		float ExpDiff = NextLvl - CurrentLvl;
		gameObject.GetComponent<Slider> ().value = TilNextLvl / ExpDiff;
		if ( XP >= NextLvl2) { 
			LevelUp ();
		}
	}

	public void LevelUp ()
	{
		NextLvl2 = (((Level + 1) * (Level + 1)) / (0.6f * 0.6f));
		print("Leveled up!");
		IncreaseStat.FreePoints = IncreaseStat.FreePoints +5;

	}

}
