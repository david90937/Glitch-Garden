using UnityEngine;
using System.Collections;

public class MusicPlayer : MonoBehaviour {
	static MusicPlayer instance = null;
	public AudioClip StartClip;
	public AudioClip Level_01;
	public AudioClip Level_02;
	public AudioClip Level_03;
	public AudioClip Level_04;
	public AudioClip Level_05;
	public AudioClip Level_06;
	public AudioClip LoseClip;
	private AudioSource Music;

	void Start ()
	{
		if (instance != null && instance != this) {
			Destroy (gameObject);
			print ("Duplicate music player self-destructing!");
		} else {
			instance = this;
			GameObject.DontDestroyOnLoad (gameObject);
			Music = gameObject.GetComponent<AudioSource> ();
			Music.clip = StartClip;
			Music.Play ();
			if (Application.loadedLevel == 0) {
				Music.loop = false; } else {Music.loop = true; }
		}

	}


	public void OnLevelWasLoaded (int Level)
	{
		print ("Music Player loaded level "); 
		Music.Stop ();
		if (Level == 0) {
			Music.clip = StartClip;
		}
		if (Level == 1) {
			Music.clip = Level_01;
		}
		if (Level == 2) {
			Music.clip = Level_02;
		}
		if (Level == 3) {
			Music.clip = Level_03;
		}
		if (Level == 4) {
			Music.clip = Level_04;
		}
		if (Level == 5) {
			Music.clip = Level_05;
		}
		if (Level == 6) {
			Music.clip = Level_06;
		}
		 Music.Play();
	}

	public void ChangeVolume (float volume)
	{
		this.gameObject.GetComponent<AudioSource>().volume = volume;
	}
		
}
