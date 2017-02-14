using UnityEngine;
using System.Collections;

public class Scroll : MonoBehaviour {

	public float speed;
	Renderer render;

	void Start () {
		render = transform.GetComponent<Renderer>();
	}
	
	void Update () {
		Vector2 offset = new Vector2(0,speed * Time.time);
		render.material.mainTextureOffset = offset;
	}
}
