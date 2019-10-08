using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jump : MonoBehaviour {

	//Jumping
	[Range(1, 10)]
	public float jumpVelocity;
	public float fallMultiplier = 5.5f;
	public float lowJumpMultiplier = 2.5f;
	private bool isGrounded;  


	void OnCollisionEnter2D(Collision2D col){
        GameObject g = col.gameObject;
        Vector2 off = GetComponent<CapsuleCollider2D>().offset; // CapsuleCollider2D
        Vector3 cpos = transform.position + new Vector3(off.x, off.y, 0);
        Vector2 sz = g.GetComponent<SpriteRenderer>().size;
        Vector2 csz = GetComponent<CapsuleCollider2D>().size; // CapsuleCollider2D
        if (cpos.y - csz.y / 2 >= g.transform.position.y + sz.y)
            isGrounded = true;
    }

    void OnCollisionExit2D(Collision2D col)
    {
        isGrounded = false;
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
