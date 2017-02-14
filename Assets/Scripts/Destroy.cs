using UnityEngine;
using System.Collections;

public class Destroy : MonoBehaviour {

	public float speed;

	void OnEnable () {
		Invoke("DestroyShit",speed);
	}
		
	void DestroyShit() {
		gameObject.SetActive(false);
	}

	void OnDisable(){
		CancelInvoke();
	}
}
