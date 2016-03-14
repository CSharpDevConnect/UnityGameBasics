using UnityEngine;
using System.Collections;

public class CrateScript : MonoBehaviour {

	public float speed = -4.0f;

	public Rigidbody2D rigidBody;

	void Start () {

		speed = -4.0f;
	}

	void FixedUpdate () {
	
		rigidBody.velocity = new Vector2 (speed, 0f);
	}

	void OnTriggerEnter2D (Collider2D other) {

		if (other.gameObject.tag == "Destroy") {
			Destroy(gameObject);
		}
	}
}
