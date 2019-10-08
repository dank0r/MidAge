using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class PlayerController : MonoBehaviour {

	//movement AxisX
	public float speed = 20f;
	public float shiftSpeed = 2f;
	private float curSpeed;

	//GetComponent
	private Rigidbody2D rb;

    public GameObject sword;
    private Vector3 sw_xyz;

	void Start () {
		rb = GetComponent<Rigidbody2D> ();
		curSpeed = speed;
        sw_xyz = sword.transform.position - transform.position;
	}

    void Update()
    {

        if (Input.GetKey(KeyCode.LeftShift))
        {
            curSpeed = shiftSpeed;
        }
        else
        {
            curSpeed = speed;
        }

        float moveX = Input.GetAxis("Horizontal");
        rb.velocity = new Vector2(moveX * curSpeed, rb.velocity.y);




        Vector3 p = transform.position;
        sword.transform.position = p + sw_xyz;

        if (moveX > 0)
        {
            GetComponent<SpriteRenderer>().flipX = false;
            sword.GetComponent<SpriteRenderer>().flipX = false;
        }
        else if (moveX < 0)
        {
            GetComponent<SpriteRenderer>().flipX = true;
            sword.GetComponent<SpriteRenderer>().flipX = true;
        }
        if (sword.GetComponent<SpriteRenderer>().flipX)
            sword.transform.position += Vector3.right * (-2 * sw_xyz.x);
    }
}
