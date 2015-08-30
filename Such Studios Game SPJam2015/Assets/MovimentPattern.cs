using UnityEngine;
using System.Collections;

public class MovimentPattern : MonoBehaviour {

	public enum patterns{straight, distance, Curves, ramdom,rush };
	public float speed = 1f;
	public patterns pattern;
	public GameObject target;
	private int wait = 0;
	private Vector3 destination;

	private bool readyToRush = false;
	// Use this for initialization
	void Start () {
	
	
	
	}
	
	// Update is called once per frame
	void Update () {
		move ();
		
	


	}
	private void move()
	{
		switch (pattern) {
		case(patterns.straight):
				moveStraight();
			break;
		case(patterns.distance):
			moveDistance();
			break;
		case(patterns.rush):
			moveRush();
			break;
		//case(patterns.spiral):
			//moveSpiral();
		//	break;
		case(patterns.ramdom):
			moveRandom();
			break;

		}
	

	}
	private void moveStraight()
	{if(transform.position.x - target.transform.position.x > 0)
		transform.position += Vector3.Normalize(new Vector3(-(transform.position.x - target.transform.position.x),-(transform.position.y - target.transform.position.y),0))*Time.deltaTime*speed;
		else
			transform.position += Vector3.Normalize(new Vector3((transform.position.x - target.transform.position.x),(transform.position.y - target.transform.position.y),0))*Time.deltaTime*speed;

	}
	private void moveDistance()
	{

		if ((transform.position.y) < target.transform.position.y + 0.03f && (transform.position.y) > target.transform.position.y - 0.03f) 
			{
			readyToRush = true;


			}
		
		else if (transform.position.y != target.transform.position.y) {
			transform.position += Vector3.Normalize (new Vector3 (0, -(transform.position.y - target.transform.position.y), 0)) * Time.deltaTime * speed;



		}
	}
		private void moveRush()
	{
		if (wait < 180 && readyToRush)
			wait ++;

		else if (readyToRush)
		{
			speed = 30;
			moveStraight ();
		} 
			else
			moveDistance ();

	}
	/*private void moveCurves()
	{
	



	}
*/
	private void moveRandom()
	{
		if (Vector3.Distance (transform.position, destination) < 0.5f) 
		{
			if (wait < 60 && readyToRush)
				wait ++;

			destination = new Vector3 (Random.Range (transform.position.x -8.0f, 0.0f),
			                           Random.Range (-4.0f, 4.0f),
			                           0.0f);
			speed = Random.Range (2.0f, 6.0f);
		
		} else
		
			transform.position += Vector3.Normalize(new Vector3 (-(transform.position.x - destination.x), -(transform.position.y - destination.y), 0))*Time.deltaTime*speed;

	}

}
