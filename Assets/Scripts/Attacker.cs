using UnityEngine;
using System.Collections;

public class Attacker : MonoBehaviour {

	[Range (0f, 3f)] float currentSpeed;
	[Tooltip ("Average number of enemies of this type spawned every x seconds")] 
	public float SpawnsEvery;
	private GameObject currentTarget;
	private Animator anim;
	private Health hp;
	
	// Use this for initialization
	void Start () {
		anim = GetComponent<Animator>();
		hp = GetComponent<Health>();
	}
	
	// Update is called once per frame
	void Update ()
	{
		transform.Translate (Vector3.left * currentSpeed * Time.deltaTime);
		if (!currentTarget) {
			anim.SetBool("isAttacking", false);
		}
	
	}

	void OnTriggerEnter2D (Collider2D trigger)
	{
		
		if (trigger.gameObject.GetComponent<Projectile> ()) {
			Destroy (trigger.gameObject);
			hp.health -= trigger.gameObject.GetComponent<Projectile> ().GetDamage ();  

			}
		//if (trigger.gameObject.GetComponent<Defender>()) {}
		}

	public void SetSpeed(float speed) {
		currentSpeed = speed;
	}

	public void Attack (GameObject obj)
	{
		anim.SetBool("isAttacking", true); 
		currentTarget = obj;
	}	
	public void DealDamage (float damage)
	{ 
		currentTarget.GetComponent<Health>().health -= damage; }

	public float ExpValue ()
	{
		if (gameObject.GetComponent<Fox> ()) {
			return 1f; }

		if (gameObject.GetComponent<Slime> ()) {
			return 2f; }

		if (gameObject.GetComponent<RedFox> ()) {
			return 3f; }

		if (gameObject.GetComponent<RedSlime> ()) {
			return 5f; }

		else return 0f;
	}
}
