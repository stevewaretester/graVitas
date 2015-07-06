using UnityEngine;
using System.Collections;

[RequireComponent (typeof (CharacterController))]


public class basicMovement : MonoBehaviour {
	
	//Variables
	public float speed = 6.0F;
	public float jumpSpeed = 8.0F; 
	public float gravity = 20.0F;
	private Vector3 moveDirection = Vector3.zero;


	void Update() {
		CharacterController controller = GetComponent<CharacterController>();
		// is the controller on the ground?
			//Feed moveDirection with input.
			moveDirection = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
			moveDirection = transform.TransformDirection(moveDirection);
			//Multiply it by speed.
			moveDirection *= speed;
			//Jumping
			if (Input.GetButton("Jump"))
				moveDirection.y = jumpSpeed;
			
		

		//Making the character move
		controller.Move(moveDirection * Time.deltaTime);
	}



}
