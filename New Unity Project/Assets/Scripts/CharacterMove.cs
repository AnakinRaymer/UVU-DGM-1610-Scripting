using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterMove : MonoBehaviour {

	// Player Movement Variables
	public int MoveSpeed;
	public float JumpHeight = 15;

	// Player grounded variables
	public Transform GroundChecks;
	public float GroundCheckRadius;
	public LayerMask WhatIsGrounded;
	private bool Grounded;

	// Use this for initialization
	void Start () {
		print("Hello World!");
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	// Update is called once per frame
	void Update () {
			Grounded = Physics2D.OverlapCircle(Groundcheck.Position, GroundCheckRadius, WhatIsGround);

		// Update is called once per frame
		void Update () {
			if(Input.GetKeyDown (KeyCode.Space)&& Grounded){
				Jump();
			}

			// This code makes the character move from side to side using the
			if(Input.GetKey (KeyCode.D)){}
				GetComponent
		}
	}
	public void Jump(){
		GetComponent<Rigidbody2D>().Velocity = new Vector2(GetComponent<Rigidbody2D>().velocity.x, JumpHeight);
	}
	// This code makes the character move from side to side using the A&D keys
	if(Input.GetKeyDown (KeyCode.D)){
		GetComponent<Rigidbody2D>().velocity = new Vector2(MoveSpeed, GetComponent<Rigidbody2D>().velocity.y);
	}
	if(Input.GetKey (KeyCode.A)){
		GetComponent<Rigidbody2D>().velocity = new Vector2(-MoveSpeed GetComponent<Rigidbody2D>().velocity.y);
	}
	}
}
