using UnityEngine;
using System.Collections;

public class PlayerAttributes : MonoBehaviour {

	private int vidas = 3;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}


	void OnTriggerEnter2D (Collider2D col){
	
		if (col.gameObject.name == "tiroInimigo(Clone)") {
			vidas--;
			Destroy(col.gameObject);
		}
	
	}
}
