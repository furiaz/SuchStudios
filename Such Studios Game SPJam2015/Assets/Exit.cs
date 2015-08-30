using UnityEngine;
using System.Collections;

public class Exit : MonoBehaviour {



	public void OnMouseDown()
	{
		Debug.Log ("EXIT");
		Application.Quit();

	}
}
