using UnityEngine;
using System.Collections;

public class Health : MonoBehaviour {

	public float health;

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update ()
	{
		if (gameObject.GetComponent<Attacker> ()) {
			float currentExp = PlayerPrefManager.GetExperience ();
			float expValue = gameObject.GetComponent<Attacker> ().ExpValue ();
			if (health <= 0f) {
				PlayerPrefManager.SetExperience (currentExp + expValue);
				Destroy (gameObject);
			}
		}
		if (gameObject.GetComponent<Defender>()) {
			if (health <= 0f) {
				Destroy(gameObject); }
		}
	}
}
