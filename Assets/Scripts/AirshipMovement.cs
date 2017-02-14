using UnityEngine;
using System.Collections;
using UnityStandardAssets.CrossPlatformInput;

[RequireComponent (typeof (CharacterController))]

public class AirshipMovement : MonoBehaviour {
	private float speed = 10;

	private CharacterController controller;
	private Quaternion targetRotation;
	private Animator anim;

	void Start () {
		controller = GetComponent<CharacterController>();
		anim = GetComponent<Animator>();
	}

	void Update () {
		Vector3 pos = Camera.main.WorldToViewportPoint (transform.position);
		pos.x = Mathf.Clamp(pos.x,0.1f,0.9f);
		pos.y = Mathf.Clamp(pos.y,0.1f,0.9f);
		transform.position = Camera.main.ViewportToWorldPoint(pos);

		Vector3 input = new Vector3(Input.GetAxisRaw("Horizontal"),Input.GetAxisRaw("Vertical"),0);
		//Vector3 input = new Vector3(CrossPlatformInputManager.GetAxisRaw("Horizontal"),CrossPlatformInputManager.GetAxisRaw("Vertical"),0);

		Vector3 motion = input;
		motion *= (Mathf.Abs(input.x) == 1 && Mathf.Abs(input.z) == 1)?0.7f:1;
		motion *= speed;
		anim.SetFloat("Input",input.x);
		controller.Move(motion * Time.deltaTime);

	}


}