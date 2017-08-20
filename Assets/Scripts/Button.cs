using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Button : MonoBehaviour {
	public GameObject defenderPrefab;
	private Button[] buttonArray;
	public static GameObject SelectedDefender; 
	// Use this for initialization
	void Start ()
	{
		buttonArray = GameObject.FindObjectsOfType<Button>();
		gameObject.GetComponent<SpriteRenderer> ().color = Color.black;
	}
	
	// Update is called once per frame
	void Update ()
	{

	}

	void OnMouseDown ()
	{
		foreach (Button thisButton in buttonArray) {
			thisButton.gameObject.GetComponent<SpriteRenderer> ().color = Color.black; 
		gameObject.GetComponent<SpriteRenderer> ().color = Color.white;
		SelectedDefender = defenderPrefab; 
		} 
	}
}
