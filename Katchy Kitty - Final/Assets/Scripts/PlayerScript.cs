using UnityEngine;
using System.Collections;

public class PlayerScript : MonoBehaviour {

	public float forwardForce = 1.0f;
	public float jumpForce = 5.0f;

	public Rigidbody2D myRigidbody;
	public Animator myAnimator;

	private bool canJump;

	public bool win = false;
	public bool lose = false;

	public CrateSpawnScript crateSpawn;
	public CrateScript crateSpeed;
	public BackgroundScrolling scrollSpeed;

	void FixedUpdate () {

		if (Mathf.Abs (myRigidbody.velocity.y) == 0) {

			canJump = true;
			myRigidbody.velocity = new Vector2 (forwardForce, 0);

		} else {

			canJump = false;
		}

		if (Input.GetButtonDown ("Fire1") && canJump) {
			myRigidbody.velocity = new Vector2 (forwardForce, jumpForce);
		}
	}

	void OnTriggerEnter2D (Collider2D other) {

		if (other.gameObject.tag == "Kitty") {

			Debug.Log("win");

			winGame();
		}

		if (other.gameObject.tag == "Destroy") {

			lose = true;
			gameObject.SetActive(false);

			Debug.Log ("lose");
		}
	}

	void winGame () {

		myAnimator.SetBool("win", true);
		scrollSpeed.speed = 0.0f;
		crateSpawn.gameOn = false;
		crateSpeed.speed = 0.0f;
		forwardForce = 0.0f;
		jumpForce = 0.0f;

		win = true;
	}
}
