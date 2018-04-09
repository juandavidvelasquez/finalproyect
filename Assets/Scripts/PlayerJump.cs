using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerJump : MonoBehaviour {

	public float  Speed = 10f ;
	public float Jumpforce = 12f;
	private float gravity = 10f ;
	private Vector3 moveDi = Vector3.zero;


	void Update () 
	{
		CharacterController controller = gameObject.GetComponent<CharacterController> ();

		if (controller.isGrounded) {
			moveDi = new Vector3 (Input.GetAxis ("Horizontal"), 0, Input.GetAxis ("Vertical"));

			moveDi = transform.TransformDirection (moveDi);

			moveDi *= Speed;

			if (Input.GetButton("Fire2")) {
				moveDi.y = Jumpforce;
			}
		}
		moveDi.y -= gravity * Time.deltaTime;

		controller.Move (moveDi * Time.deltaTime);
	}
}
