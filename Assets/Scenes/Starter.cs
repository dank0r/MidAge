using UnityEngine;
using UnityEngine.Tilemaps;
using UnityEngine;

public class Starter : MonoBehaviour {

	// Use this for initialization
	void Start () {	
		Tilemap tilemap = GetComponent<Tilemap>();

		BoundsInt bounds = tilemap.cellBounds;
		TileBase[] allTiles = tilemap.GetTilesBlock(bounds);
		TileBase tile = allTiles [0];
		Debug.Log (allTiles.Length);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
