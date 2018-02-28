using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//Autores Rodrigo Samayoa y David Soto

public class Meteoro : MonoBehaviour {
    public GameObject asteroide; //El objeto que se va a instanciar
    public float spawnTime = 1f; //Tiempo que va a tardar para crear otro objeto
    public float elapsedTime = 0;

	public ParticleSystem fire;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update()
	{
		if (GameController.instance.gamOver == false)
		{
			//Mientras siga el juego
			if (elapsedTime < spawnTime)
			{
				elapsedTime += Time.deltaTime; //Tiempo para generar los asteroides
			}
			else
			{
				float random = Random.Range(-2.5f, 2.5f); //Rango que debe aparecer en la pantalla
				Instantiate(asteroide, new Vector3(random, 5, 0), Quaternion.identity); //Se genera el asteroide
				elapsedTime = 0; //El tiempo para generar comienza de nuevo
			}
		}
	}

	private void OnCollisionEnter2D(Collision2D collision)
		{
			if (collision.gameObject.name == "Disparo(Clone)") //Condicion para hacer que salga la animacion de una explocion
			{
				fire.Play();
			}
		}
	}
