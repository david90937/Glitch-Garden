using UnityEngine;
using System.Collections;

public class Projectile : MonoBehaviour {

	public float speed, damage;

	// Use this for initialization
	void Start () {
		
	}

	public float GetDamage ()
	{
		return damage + (PlayerPrefManager.GetIntelligence() / 5); 
	}
	void Hit ()
	{

	}
	
	// Update is called once per frame
	void Update ()
	{
		transform.Translate (Vector3.right * speed * Time.deltaTime);
		if (transform.position.x > 10) {
			Destroy(gameObject);
		}

	}
}
