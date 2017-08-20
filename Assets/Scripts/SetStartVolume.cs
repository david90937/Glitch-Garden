using UnityEngine;
using System.Collections;

public class SetStartVolume : MonoBehaviour {

	private MusicPlayer musicPlayer;
	// Use this for initialization
	void Start () {
		musicPlayer = GameObject.Find("Music Player").GetComponent<MusicPlayer>();
		musicPlayer.GetComponent<AudioSource>().volume = PlayerPrefManager.GetMasterVolume(); 
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
