using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class StarDisplay : MonoBehaviour {
	public enum Status {Success, Failure}
	public Text text;
	public static int stars;
	// Use this for initialization
	void Start ()
	{
		if (Application.loadedLevel == 3) {
			stars = 250;
		}
		if (Application.loadedLevel == 4) {
			stars = 350;
		}
		if (Application.loadedLevel == 5) {
			stars = 500;
		}
		if (Application.loadedLevel == 6) {
			stars = 600;
		}

		text.text = stars.ToString();
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void AddStars(int amount) {
		stars += amount;
		text.text = (stars).ToString();
	}

	public Status UseStars (int amount)
	{
		if (stars >= amount) {
			stars -= amount;
			text.text = (stars).ToString (); 
			return Status.Success; }
		return Status.Failure;
	}
}
