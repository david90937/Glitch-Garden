using UnityEngine;
using System.Collections;

public class Shooter : MonoBehaviour {

	public GameObject projectile;
	public float range;
	private GameObject projectileParent; 
	private Animator anim;
	private SpawnerController LaneSpawn; 



	void Start ()
	{
		anim = gameObject.GetComponent<Animator>();
		GameObject.FindObjectsOfType<SpawnerController>();

		projectileParent = GameObject.Find("Projectiles"); 
		if (!projectileParent) { // this if statement organizes projectiles into a parent object as they are spawned
			projectileParent = new GameObject("Projectiles");  
		}
		setLaneSpawn();
		print(LaneSpawn);

	}

	void Update ()
	{
		if (InRange()) {
			anim.SetBool ("isAttacking", true);
		} else {
			anim.SetBool ("isAttacking", false);}

		
	}

	public void Fire ()
	{
		GameObject newProjectile = Instantiate(projectile);
		newProjectile.transform.parent = projectileParent.transform;
		newProjectile.transform.position = gameObject.transform.FindChild("Gun").transform.position;
	}


	bool InRange ()
	{
		if (LaneSpawn.transform.childCount > 0) {
			foreach (Transform attacker in LaneSpawn.transform) { 
				if (attacker.transform.position.x - transform.position.x <= range) {
					return true;
				} else { return false; }
			}
		} return false;
	}

	void setLaneSpawn ()
	{
		SpawnerController[] SpawnArray = GameObject.FindObjectsOfType<SpawnerController>();
		foreach (SpawnerController spawner in SpawnArray) { 
			if (spawner.transform.position.y == transform.position.y) {
				LaneSpawn = spawner;
				return;
			}
		} Debug.LogError ("Can't find spawner in lane");
	} 
}
