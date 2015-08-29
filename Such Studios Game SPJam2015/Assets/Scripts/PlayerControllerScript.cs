using UnityEngine;
using System.Collections;

public class PlayerControllerScript : MonoBehaviour {

	private const float speed = 5.0f;
	public GameObject tiroJogador;
	private bool disparando = false;


	// Use this for initialization
	void Start () {

	
	}
	
	// Update is called once per frame
	void Update () {


		if (Input.GetButton ("Fire1")) {
			//ToDo: Poder Especial
			disparando = true;
		}
		else {
			disparando = false;
		}

		if (disparando) {
			Instantiate(tiroJogador, transform.position, Quaternion.Euler(0, 0, 90));
		}
		

		transform.position += new Vector3 (Input.GetAxis("Horizontal") * speed * Time.deltaTime, Input.GetAxis("Vertical") * speed * Time.deltaTime, 0);

	}
}
