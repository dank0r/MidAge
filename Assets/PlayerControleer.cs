using UnityEngine;

public class PlayerControleer : MonoBehaviour {

	public float speed = 20f;
	private Rigidbody2D rb;

	void Start () {
		rb = GetComponent<Rigidbody2D> ();

	}

	void Update () {
		float moveX = Input.GetAxis ("Horizontal"); 
		if (moveX > 0) {
			GetComponent<SpriteRenderer> ().flipX = false;
		} else {
			GetComponent<SpriteRenderer> ().flipX = true;
			
		}
		rb.MovePosition (rb.position + Vector2.right * moveX * speed * Time.deltaTime);

		if (Input.GetKeyDown (KeyCode.Space))
			rb.AddForce (Vector2.up * 80000 * Time.deltaTime);
	}
}
