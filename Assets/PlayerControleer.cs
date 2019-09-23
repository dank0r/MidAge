using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class PlayerControleer : MonoBehaviour {

	//movement AxisX
	public float speed = 20f;


	//GetComponent
	private Rigidbody2D rb;

	void Start () {
		rb = GetComponent<Rigidbody2D> ();
	}

	void Update () {
		float moveX = Input.GetAxis ("Horizontal"); 
		if (moveX > 0) 
			GetComponent<SpriteRenderer> ().flipX = false;
		else if (moveX < 0)
			GetComponent<SpriteRenderer> ().flipX = true;
		
		//rb.MovePosition (rb.position + Vector2.right * moveX * speed * Time.deltaTime);
	}
}
