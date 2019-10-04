using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class PlayerControleer : MonoBehaviour {

	//movement AxisX
	public float speed = 20f;
	public float shiftSpeed = 2f;
	private float curSpeed;

	//GetComponent
	private Rigidbody2D rb;

	void Start () {
		rb = GetComponent<Rigidbody2D> ();
		curSpeed = speed;
	}

	void Update () {

		if (Input.GetKey (KeyCode.LeftShift)) {
			curSpeed = shiftSpeed;
		} else {
			curSpeed = speed;
		}

		float moveX = Input.GetAxis ("Horizontal"); 
		rb.velocity = new Vector2(moveX * curSpeed, rb.velocity.y);




		if (moveX > 0) {
			GetComponent<SpriteRenderer> ().flipX = false;
		} else if (moveX < 0) {
			GetComponent<SpriteRenderer> ().flipX = true;
		}
	}
}
