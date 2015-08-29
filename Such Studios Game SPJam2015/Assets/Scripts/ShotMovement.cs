using UnityEngine;
using System.Collections;

public class ShotMovement : MonoBehaviour {

	public float speed;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		move ();
	
	}

	private void move(){

		transform.position += new Vector3 (Mathf.Cos (Mathf.Deg2Rad * (transform.eulerAngles.z - 90)) * speed * Time.deltaTime
		                                  , Mathf.Sin (Mathf.Deg2Rad * (transform.eulerAngles.z - 90)) * speed * Time.deltaTime,
		                                  0);

	}

}
