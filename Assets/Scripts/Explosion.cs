using UnityEngine;
using System.Collections;

public class Explosion : MonoBehaviour {

	public Animator anim;
	public bool done;

	void Start () {
		anim = GetComponent<Animator>();
	}
	
	void Update () {
		if(anim.GetCurrentAnimatorStateInfo(0).normalizedTime >= anim.GetCurrentAnimatorStateInfo(0).length){
			done = true;
			gameObject.SetActive(false);
		}
	}
}
