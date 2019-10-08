﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jump : MonoBehaviour {

	//Jumping
	[Range(1, 10)]
	public float jumpVelocity;
	public float fallMultiplier = 5.5f;
	public float lowJumpMultiplier = 2.5f;
	private bool isGrounded;  


	void OnCollisionEnter2D(Collision2D col)
	{
		isGrounded = true;
	}

	private Rigidbody2D rb;

	// Use this for initialization
	void Start () {
		isGrounded = true;
		rb = GetComponent<Rigidbody2D> ();
	}
	
	// Update is called once per frame
	void Update () {

		//Jump
		if (Input.GetButton ("Jump") && isGrounded) {
			GetComponent<Rigidbody2D> ().velocity = Vector2.up * jumpVelocity;
			isGrounded = false;
		}
		if (rb.velocity.y < 0) {
			rb.velocity += Vector2.up * Physics2D.gravity.y * (fallMultiplier) * Time.deltaTime;  
		} else if (rb.velocity.y > 0 && !Input.GetButton ("Jump")) {
			rb.velocity += Vector2.up * Physics2D.gravity.y * (lowJumpMultiplier) * Time.deltaTime;  
		}
	}
}
