using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attack : MonoBehaviour {

	private Animator an;

	// Use this for initialization
	void Start () {
		an = GetComponent<Animator> ();
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetButton("Jump")) {
			an.SetBool ("isAttack", true);
		} else {
			an.SetBool ("isAttack", false);
		}
	}
}
