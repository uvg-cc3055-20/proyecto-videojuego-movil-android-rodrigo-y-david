using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//Autores Rodrigo Samayoa y David Soto

public class Piedrita : MonoBehaviour {
    public GameObject piedrita; //El objeto que se va a instanciar
    public float spawnTime = 2f; //Tiempo que va a tardar para crear otro objeto
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
                elapsedTime += Time.deltaTime; //Tiempo para generar las piedritas
            }
            else
            {
                float random = Random.Range(-2.5f, 2.5f); //Rango que debe aparecer en la pantalla
                Instantiate(piedrita, new Vector3(random, 5, 0), Quaternion.identity); //Se genera la piedrita
                elapsedTime = 0; //El tiempo para generar comienza de nuevo
            }
        }
    }
}
