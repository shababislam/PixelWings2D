using UnityEngine;
using System.Collections;

public class GetHit : MonoBehaviour {

	public GameObject explosion;
	bool hit;

	void Start(){
		explosion.SetActive(false);
	}


	void OnTriggerEnter2D(Collider2D other){
		if(other.tag == "Enemy"){
			explosion.transform.position = transform.position;
			explosion.SetActive(true);

			transform.root.gameObject.SetActive(false);
			GameMaster.playerAlive = false;
		}
	}
}