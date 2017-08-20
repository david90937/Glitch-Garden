using UnityEngine;
using System.Collections;

[RequireComponent (typeof (Attacker))]
public class Slime : MonoBehaviour {
	 

	private Animator anim;
	private Attacker attacker;
	private Defender defend; 
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
		defend = trigger.gameObject.GetComponent<Defender>(); 
		if (!defend) {
			return; }
		else {  
			attacker.Attack(trigger.gameObject); }
			}
	}
