using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
//Autores Rodrigo Samayoa y David Soto

public class GameController : MonoBehaviour {

	[Header("Jugador")]
	public bool gamOver = false;
	public float currentHighscore = 0;
	public float time;
    public static GameController instance;
	public Text timeLabel2;



    // Use this for initialization
    void Start () {
        instance = this;
	}
	
	// Update is called once per frame
	void Update () 
	{ 
		if (gamOver == false) {
			time += Time.deltaTime * 1000;
			timeLabel2.text = time.ToString ("n0");
		}
		else
		{
			endGame();
		}


    }

	public void endGame()//funcion que declara cual es el highscore del jugador
	{
		gamOver = false;
		currentHighscore = PlayerPrefs.GetFloat("Highscore");	
		if(currentHighscore < time)
		{
			currentHighscore = time;
			PlayerPrefs.SetFloat("Highscore", currentHighscore);
		}
	}
}
