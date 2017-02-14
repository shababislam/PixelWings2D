using UnityEngine;
using System.Collections;

public class Bullet : MonoBehaviour {

	public float speed;
	public bool hit;

	void Update () {
		transform.Translate(0,speed * Time.deltaTime,0);
	}

	void OnTriggerEnter2D(Collider2D other){
		if(other.tag == "Enemy" && GameMaster.playerAlive){
			GameMaster.score+=3;
			other.gameObject.GetComponent<EnemyMove>().Destroy();
		}
	}
}
