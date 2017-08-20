using UnityEngine;
using System.Collections;

public class Stone : MonoBehaviour {
	private Animator anim;

	// Use this for initialization
	void Start () {
		anim = gameObject.GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerStay2D (Collider2D trigger)
	{
		Attacker attacker = trigger.gameObject.GetComponent<Attacker> ();
		if (attacker) {
			anim.SetTrigger ("UnderAttack");
		}
	}

	void OnTriggerExit2D (Collider2D trigger)
	{
		Attacker attacker = trigger.gameObject.GetComponent<Attacker> ();
		if (!attacker) {
			anim.SetTrigger ("NotUnderAttack");
		}
	}
}
