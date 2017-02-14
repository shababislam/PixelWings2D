using UnityEngine;
using System.Collections;

public class EnemyDestroy : MonoBehaviour {

	void OnEnable () {
		Invoke("Destroy",10f);
	}

	// Update is called once per frame
	void Destroy () {
		gameObject.SetActive(false);
	}

	void OnDisable(){
		CancelInvoke();
	}
}
