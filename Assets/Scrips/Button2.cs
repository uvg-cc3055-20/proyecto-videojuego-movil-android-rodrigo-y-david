using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Button2: MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	
	public void cambiarEscena()//metodo que hace que al precionar el boton cambie de escena.
	{
		SceneManager.LoadScene ("Game", LoadSceneMode.Single); //Cambia de escena al Menu
	}
}
