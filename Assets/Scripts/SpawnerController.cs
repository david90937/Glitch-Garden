using UnityEngine;
using System.Collections;

public class SpawnerController : MonoBehaviour {

	public GameObject[] EnemyArray;
	public float SpawnRate;
	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
		foreach (GameObject enemy in EnemyArray)
			if (TimeToSpawn(enemy)) {
				Spawn(enemy); }
	}

	void Spawn (GameObject enemy)
	{
		GameObject Enemy = Instantiate(enemy);
		Enemy.transform.parent = transform;
		Enemy.transform.position = gameObject.transform.position; // could also use Enemy.transform.parent = transform; (because spawners are never destroyed).
		
	}

	bool TimeToSpawn (GameObject attackerGameObject)
	{
		// I'm really not a fan of this method. HAS to be something better/simpler...
		Attacker attacker = attackerGameObject.GetComponent<Attacker> ();
		float spawnDelay = attacker.SpawnsEvery;
		float spawnsPersecond = 1 / spawnDelay;
		if (Time.deltaTime > spawnDelay) {
			Debug.LogWarning ("Spawn capped by frame-rate");
		}
		float threshold = spawnsPersecond * Time.deltaTime / SpawnRate;
		if (Random.value < threshold) {
			return true;
		} else { return false;}
	}
}
