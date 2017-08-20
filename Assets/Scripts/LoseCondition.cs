using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class LoseCondition : MonoBehaviour {
	public int LevelHealth;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter2D (Collider2D trigger )
	{
		LevelHealth -= 1;
		Destroy(trigger.gameObject);
			if (LevelHealth <= 0) {
			gameObject.GetComponent<AudioSource>().Play(); 
			Invoke("Lose", 2.5f);

			}
	}

	void Lose ()
	{
		SceneManager.LoadScene("Lose"); 
	}

}
