using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

//Autores Rodrigo Samayoa y David Soto

public class Cometa : MonoBehaviour {
    public GameObject cometa; //El objeto que se va a instanciar
    public float spawnTime = 1f; //Tiempo que va a tardar para crear otro objeto
    public float elapsedTime = 0;
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (GameController.instance.gamOver == false)
        { //Mientras siga el juego
            if (elapsedTime < spawnTime)
            {
                elapsedTime += Time.deltaTime; //Tiempo para generar los cometas
            }
            else
            {
                float random = Random.Range(-2.5f, 2.5f); //Rango que debe aparecer en la pantalla
                Instantiate(cometa, new Vector3(random, 5, 0), Quaternion.identity); //Se genera el cometa
                elapsedTime = 0; //El tiempo para generar comienza de nuevo
            }
        }
    }
}
