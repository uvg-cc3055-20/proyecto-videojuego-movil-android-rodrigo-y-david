using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//Autores Rodrigo Samayoa y David Soto

public class Meteoro : MonoBehaviour {
    public GameObject asteroide; //El objeto que se va a instanciar
    public float spawnTime = 2f; //Tiempo que va a tardar para crear otro objeto
    public float elapsedTime = 0;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if(GameController.instance.gamOver == false){
            if (elapsedTime < spawnTime)
            {
                elapsedTime += Time.deltaTime;
            }
            else
            {
                float random = Random.Range(-2.5f, 2.5f); //Rango que debe aparecer en la pantalla
                Instantiate(asteroide, new Vector3(random, 5, 0), Quaternion.identity);
                elapsedTime = 0;
            }
        }
    }
}
