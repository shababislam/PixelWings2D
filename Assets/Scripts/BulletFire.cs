using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class BulletFire : MonoBehaviour {

	public int numBullets;
	public float fireTime;
	public GameObject bullet;
	List<GameObject> bullets;

	void Start () {
		bullets = new List<GameObject>();
		for(int i = 0;i<numBullets;i++){
			GameObject obj = (GameObject)Instantiate(bullet);
			obj.SetActive(false);
			bullets.Add(obj);
		}

	}

	void Update(){
		if(GameMaster.playerAlive){
			Invoke("Fire",fireTime);
		} else {
			CancelInvoke();
		}
	}

	void Fire() {
		for(int i = 0;i<bullets.Count;i++){
			if(!bullets[i].activeInHierarchy){
				bullets[i].transform.position = transform.position;
				bullets[i].transform.rotation = transform.rotation;
				bullets[i].SetActive(true);
				break;
			}
		}
	
	}
}
