using UnityEngine;
using System.Collections;

public class BotaoIiniciar : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	void OnMouseDown()
	{
		Debug.Log ("PROXIMO LVL");
		Application.LoadLevel (Application.loadedLevel + 1);

	}
}
