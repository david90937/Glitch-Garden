using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class OptionsController : MonoBehaviour {

	public Slider VolumeSlider;
	public Slider DifficultySlider;
	public MusicPlayer musicPlayer; 
	public LevelManager levelManager;
	// Use this for initialization
	void Start () {
		musicPlayer = GameObject.FindObjectOfType<MusicPlayer>();
		VolumeSlider.value = PlayerPrefManager.GetMasterVolume();
		DifficultySlider.value = PlayerPrefManager.GetDifficulty();
	}
	
	// Update is called once per frame
	void Update () {
		musicPlayer.ChangeVolume(VolumeSlider.value);

	}

	public void SaveAndExit ()
	{
		PlayerPrefManager.SetMasterVolume(VolumeSlider.value);
		PlayerPrefManager.SetDifficulty(DifficultySlider.value);
		levelManager.LoadLevel("Main Menu");
	}

	public void SetDefaults ()
	{
		VolumeSlider.value = 0.8f;
		DifficultySlider.value = 2;
	}
}
