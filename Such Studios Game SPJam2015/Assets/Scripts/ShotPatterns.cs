using UnityEngine;
using System.Collections;

public class ShotPatterns : MonoBehaviour {


	public enum patternType {spiral, follow, random};
	public enum colorType {yellow, red, blue};
	private int steps = 0;
	private int wait = 0;
	public GameObject tiroInimigo;
	public GameObject target;
	public int duration;
	public int level;
	public patternType pattern;
	public int circles;
	public int relief;
	public colorType color;
	public Sprite[] bulletColors;
	private SpriteRenderer bullet;



	// Use this for initialization
	void Start () {

		switch (color) {

			case (colorType.yellow):
				Debug.Log("y");
				tiroInimigo.GetComponent<SpriteRenderer>().sprite = bulletColors[0];
			break;
			case (colorType.red):
				Debug.Log("r");
				tiroInimigo.GetComponent<SpriteRenderer>().sprite = bulletColors[1];
			break;
			case (colorType.blue):
				Debug.Log("b");
				tiroInimigo.GetComponent<SpriteRenderer>().sprite = bulletColors[2];
			break;

		}
	
	}
	
	// Update is called once per frame
	void Update () {
		if (steps < duration) {
		
			if (wait == 0) {
				shoot ();
				steps++;
				wait++;
				wait = wait % relief;
			} else {
				wait++;
				wait = wait % relief;
			}
		} else {
		
			Destroy(this);

		}

	}

	private void shoot(){
		Debug.Log (pattern);
		switch (pattern)
		{

			case (patternType.spiral):
				shootSpiral();
			break;
			case (patternType.follow):
				shootFollow();
			break;
			case (patternType.random):
				shootRandom();
			break;

		}
	}

	private void shootSpiral(){
		for (int i = 0; i < level; i++)
			Instantiate(tiroInimigo, transform.position, Quaternion.Euler (0, 0, 0 + i * 360/level - (360 * steps * circles / duration)));
	}

	private void shootFollow(){
		Instantiate (tiroInimigo, transform.position, Functions.rotateTo(tiroInimigo.transform.position, target.transform.position));
		if (level > 1) {
		
			Instantiate (tiroInimigo, transform.position, Functions.rotateTo(tiroInimigo.transform.position, target.transform.position) * Quaternion.Euler(0, 0, 51 - 3*level));
			Instantiate (tiroInimigo, transform.position, Functions.rotateTo(tiroInimigo.transform.position, target.transform.position) * Quaternion.Euler(0, 0, -51 + 3*level));

		}
	}

	private void shootRandom(){
		for (int i = 0; i < level; i++)
			Instantiate (tiroInimigo, transform.position, Quaternion.Euler(0, 0, Random.Range(0, 360)));
	}
}
