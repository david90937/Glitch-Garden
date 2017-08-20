using UnityEngine;
using System.Collections;

[RequireComponent (typeof (Attacker))]
public class Fox : MonoBehaviour {
	 

	private Animator anim;
	private Attacker attacker;
	// Use this for initialization
	void Start () {
		anim = GetComponent<Animator>();
		attacker = GetComponent<Attacker>();
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void OnTriggerEnter2D (Collider2D trigger)
	{
		if (!trigger.gameObject.GetComponent<Defender> ()) {
			return; }
			
		if (trigger.gameObject.GetComponent<Stone>()) {
			anim.SetTrigger("Jump Trigger");
		} else {  
			attacker.Attack(trigger.gameObject); }

	}

}
