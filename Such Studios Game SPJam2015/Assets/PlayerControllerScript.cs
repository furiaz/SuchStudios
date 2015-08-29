using UnityEngine;
using System.Collections;

public class PlayerControllerScript : MonoBehaviour {

	private const float speed = 5.0f;

	// Use this for initialization
	void Start () {

	
	}
	
	// Update is called once per frame
	void Update () {

		/*if (Input.GetButtonDown("Right")){
			transform.position += new Vector3(speed*Time.deltaTime, 0, 0);
		}

		if (Input.GetButtonDown("Left")){
			transform.position += new Vector3(speed*Time.deltaTime, 0, 0);
		}*/


		if (Input.GetButtonDown("Fire1")){
			//ToDo: Poder Especial
			Debug.Log("Fogo!");
		}

		transform.position += new Vector3 (Input.GetAxis("Horizontal") * speed * Time.deltaTime, Input.GetAxis("Vertical") * speed * Time.deltaTime, 0);

	}
}
