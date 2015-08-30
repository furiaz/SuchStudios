using UnityEngine;
using System.Collections;

public class Buttons : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void Sair()
	{
		Application.Quit ();
	}
	public void ProximoNivel()
	{
		Debug.Log ("biscoito com caramelo");
		Application.LoadLevel (Application.loadedLevel + 1);

	}
}
