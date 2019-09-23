﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BetterJump : MonoBehaviour {
	//Jump
	public float fallMultiplier = 4.5f;
	public float lowJumpMultiplier = 1.5f;

	//GetComponent
	private Rigidbody2D rb;

	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody2D> ();
	}
	
	// Update is called once per frame
	void Update () {
		
		if (rb.velocity.y < 0) {
			rb.velocity += Vector2.up * Physics2D.gravity.y * (fallMultiplier - 1) * Time.deltaTime;  
		} else if (rb.velocity.y > 0 && !Input.GetButton ("Jump")) {
			rb.velocity += Vector2.up * Physics2D.gravity.y * (lowJumpMultiplier - 1) * Time.deltaTime;  
		}
	}
}