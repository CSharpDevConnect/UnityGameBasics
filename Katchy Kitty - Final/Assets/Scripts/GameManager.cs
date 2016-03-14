using UnityEngine;
using System.Collections;

public class GameManager : MonoBehaviour {

	public PlayerScript status;

	void DisplayRestartButton () {
		
		if (status.win) {
			
			Rect buttonRect = new Rect (Screen.width * 0.35f, Screen.height * 0.45f, Screen.width * 0.30f, Screen.height * 0.1f);
			
			if (GUI.Button (buttonRect, "You cough the kitty! Tap to Restart")) {
				
				Application.LoadLevel (Application.loadedLevelName);
			}
		}

		if (status.lose) {
			Rect buttonRect = new Rect (Screen.width * 0.35f, Screen.height * 0.45f, Screen.width * 0.30f, Screen.height * 0.1f);
			
			if (GUI.Button (buttonRect, "The kitty got away! Tap to Restart")) {
				
				Application.LoadLevel (Application.loadedLevelName);
			}
		}
	}
	
	void OnGUI () {
		
		DisplayRestartButton();
	}
}
