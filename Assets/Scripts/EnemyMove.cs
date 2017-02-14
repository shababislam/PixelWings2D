using UnityEngine;
using System.Collections;

public class EnemyMove : MonoBehaviour {

	public float speed;
	public GameObject explosion;
	bool canMove;
	public bool done;

	void Start(){
		explosion.SetActive(false);
		canMove = true;
	}

	public void Destroy(){
		canMove = false;
		gameObject.GetComponent<SpriteRenderer>().enabled = false;
		explosion.SetActive(true);
		gameObject.GetComponent<BoxCollider2D>().enabled = false;
		if(explosion.GetComponent<Explosion>().done){
			gameObject.SetActive(false);
		}
	}

	public void Reset(){
		canMove = true;
		gameObject.GetComponent<SpriteRenderer>().enabled = true;
		explosion.SetActive(false);
		explosion.GetComponent<Explosion>().done = false;
		gameObject.GetComponent<BoxCollider2D>().enabled = true;
	}

	void Update () {
		done = explosion.GetComponent<Explosion>().done;
		if(canMove){
			transform.Translate(0,-speed * Time.deltaTime,0);
		}

	}
}
