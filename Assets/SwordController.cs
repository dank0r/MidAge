using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwordController : MonoBehaviour {

	public GameObject character;
	private Vector2 posOfCharacter;

	// Use this for initialization
	void Start () {
		Vector3 sw = GetComponent<Transform> ().position;
		Vector3 ch = character.GetComponent<Transform> ().position;

		posOfCharacter = new Vector2(sw.x, sw.y) - new Vector2(ch.x, ch.y);
	}

	// Update is called once per frame
	void Update () {
		Vector3 ch = character.GetComponent<Transform> ().position;
		Vector2 pos = new Vector2 (ch.x, ch.y) + posOfCharacter;
		GetComponent<Transform> ().position = new Vector3(pos.x, pos.y, 0);
	}
}
