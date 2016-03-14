using UnityEngine;
using System.Collections;

public class BackgroundScrolling : MonoBehaviour {

	public float speed = 0.2f;

	private Vector2 offset = Vector2.zero;

	private Material material;

	// Use this for initialization
	void Start () {

		speed = 0.2f;

		material = GetComponent<Renderer> ().material;
		offset = material.GetTextureOffset ("_MainTex");
	}
	
	// Update is called once per frame
	void Update () {

		offset.x += speed * Time.deltaTime;
		material.SetTextureOffset ("_MainTex", offset);
	}
}
