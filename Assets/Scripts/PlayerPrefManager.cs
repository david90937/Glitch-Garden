using UnityEngine;
using System.Collections;

public class PlayerPrefManager : MonoBehaviour {

	const string MASTER_VOLUME_KEY = "master_volume";
	const string DIFFICULTY_KEY = "difficulty";
	const string LEVEL_KEY = "level_unlock_";

	const string INTELLIGENCE_KEY = "Intelligence"; // this worked!
	const string EXPERIENCE_KEY = "Experience";


	public static void SetMasterVolume (float volume) {
		if (volume >= 0f && volume <= 1f) { 
			PlayerPrefs.SetFloat (MASTER_VOLUME_KEY, volume);
		} else { Debug.LogError ("Master volume out of range");}
	}

	public static float GetMasterVolume ()
	{
		return PlayerPrefs.GetFloat(MASTER_VOLUME_KEY);
	}

	public static void LevelUnlock (int level)
	{
		if (level <= Application.levelCount - 1) {
			PlayerPrefs.SetInt(LEVEL_KEY + level.ToString(), 1); // use 1 for true
		} else print("Level unlock requested for level not in build");
	}

	public static bool IsLevelUnlocked (int level)
	{
		int levelValue = PlayerPrefs.GetInt (LEVEL_KEY + level.ToString ());
		bool isLevelUnlocked = (levelValue == 1);
		if (level <= Application.levelCount - 1) {
			return isLevelUnlocked;
		} else {
			Debug.LogError ("Level already unlocked or not in build");
			return false;
		}
	}

	public static void SetDifficulty (float difficulty)
	{
		if (difficulty >= 1 && difficulty <= 3) { 
			PlayerPrefs.SetFloat (DIFFICULTY_KEY, difficulty);
		} else { Debug.LogError ("Difficulty out of range");}
	}

	public static float GetDifficulty ()
	{
		return PlayerPrefs.GetFloat(DIFFICULTY_KEY);
	}
	public static void SetIntelligence (float intelligence)
	{
		PlayerPrefs.SetFloat(INTELLIGENCE_KEY, intelligence); 
	}

	public static float GetIntelligence ()
	{
		return PlayerPrefs.GetFloat(INTELLIGENCE_KEY);
	}

	public static void SetExperience (float experience) {
		PlayerPrefs.SetFloat(EXPERIENCE_KEY, experience);
	}

	public static float GetExperience() {
		return PlayerPrefs.GetFloat(EXPERIENCE_KEY);
	}
}

