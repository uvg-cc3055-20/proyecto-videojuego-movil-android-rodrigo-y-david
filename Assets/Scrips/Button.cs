using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
//Autores Rodrigo Samayoa y David Soto

public class Button : MonoBehaviour {

	public Text Highscore;

	// Use this for initialization
	void Start () 
	{
		Highscore.text = PlayerPrefs.GetFloat ("Highscore").ToString ("n0");
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void cambiarEscena()//metodo que hace que al precionar el boton cambie de escena.
	{
		SceneManager.LoadScene ("Game", LoadSceneMode.Single);
	}
}
