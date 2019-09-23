using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jump : MonoBehaviour {

	//Jumping
	[Range(1, 10)]
	public float jumpVelocity;
	private bool isGrounded;  

	void OnCollisionEnter2D(Collision2D col)
	{
		isGrounded = true;
	}

	// Use this for initialization
	void Start () {
		isGrounded = true;
	}
	
	// Update is called once per frame
	void Update () {

		//Jump
		if (Input.GetButton ("Jump") && isGrounded) {
			GetComponent<Rigidbody2D> ().velocity = Vector2.up * jumpVelocity;
			isGrounded = false;
		}
	}
}
