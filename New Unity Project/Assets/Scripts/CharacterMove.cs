﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterMove : MonoBehaviour {

	// Player Movement Variables
	public int MoveSpeed;
	public float JumpHeight;
	private bool DoubleJump;

	// Player grounded variables
	public Transform GroundCheck;
	public float GroundCheckRadius;
	public LayerMask WhatIsGrounded;
	private bool Grounded;

	//Non-Stick Player
	private float MoveVelocity;

	// Use this for initialization
	void Start () {

	}

	void FixedUpdate () {
		Grounded = Physics2D.OverlapCircle(GroundCheck.position, GroundCheckRadius, WhatIsGrounded);
}

// Update is called once per frame
	void Update () {

	// This code makes the character jump
	if(Input.GetKey (KeyCode.Space)&& Grounded){
		Jump();
	}

	// Double jump code
	if(Grounded){
		DoubleJump = false;
	}

	if(Input.GetKeyDown (KeyCode.Space)&& !DoubleJump && !Grounded){
		Jump();
		DoubleJump = true;
	}

	

	//Non-Stick Player
	MoveVelocity = 0f;
	
	// This code makes the character move from side to side using the A&D keys
	if(Input.GetKey (KeyCode.D)){
		// GetComponent<Rigidbody2D>().velocity = new Vector2(MoveSpeed, GetComponent<Rigidbody2D>().velocity.y);
		MoveVelocity = MoveSpeed;
		// animator.SetBool("isWalking", false);
		// animator.SetFloat("Speed", Mathf.Abs(MoveVelocity);
	}
	// else if (Input.GetKeyUp.D){
	// 	animator.SetBool("isWalking", false);
	// }
	if(Input.GetKey (KeyCode.A)){
		GetComponent<Rigidbody2D>().velocity = new Vector2(-MoveSpeed, GetComponent<Rigidbody2D>().velocity.y);
		MoveVelocity = -MoveSpeed;
		// animator.SetBool("isWalking", false);
		// animator.SetFloat("Speed", Mathf.Abs(MoveVelocity);
	}
		// else if (Input.GetKeyUp.A){
		// animator.SetBool("isWalking", false);
	// }

	GetComponent<Rigidbody2D>().velocity = new Vector2(MoveVelocity, GetComponent<Rigidbody2D>().velocity.y);

	//Player flip
	if (GetComponent<Rigidbody2D>().velocity.x > 0){
	transform.localScale = new Vector3(5f,5f,1f);
	}

	else if (GetComponent<Rigidbody2D>().velocity.x < 0){
	transform.localScale = new Vector3(5f,5f,1f);
	}
	}
	public void Jump(){
		GetComponent<Rigidbody2D>().velocity = new Vector2(GetComponent<Rigidbody2D>().velocity.x, JumpHeight);
	}
}