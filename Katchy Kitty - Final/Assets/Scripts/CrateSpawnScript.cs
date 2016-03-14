using UnityEngine;
using System.Collections;

public class CrateSpawnScript : MonoBehaviour {

	public GameObject crate;

	public Transform crateSpawn;

	private float nextSpawn = 1.0f;

	public bool gameOn = true;

	void Start () {

		nextSpawn = 1.0f;
		gameOn = true;
	}

	void Update () {

		if ((Time.time > nextSpawn) && gameOn) {

			nextSpawn = Time.time + Random.Range(2.0f, 4.0f);

			Instantiate (crate, crateSpawn.position, crateSpawn.rotation);
		}

	}
}
