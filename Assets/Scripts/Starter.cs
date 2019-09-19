using UnityEngine;

public class Starter : MonoBehaviour {

	public GameObject ground;

	// Use this for initialization
	void Start () {
		for (int i = 0; i < 10; i++) {
			GameObject gr = Instantiate (ground);
			gr.transform.position = gr.transform.position + new Vector3 (i * gr.GetComponent<SpriteRenderer>().size.x, 0, 0);
			gr.GetComponent<SpriteRenderer> ().enabled = true;
		}
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
