using UnityEngine;
using System.Collections;

public class KittyScript : MonoBehaviour {

	public Animator myAnimator;

	void OnTriggerEnter2D (Collider2D other) {

		if (other.gameObject.tag == "Player") {

			myAnimator.SetBool("stop", true);
		}
	}
}
