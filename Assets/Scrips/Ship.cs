using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
//Autores Rodrigo Samayoa y David Soto

public class Ship : MonoBehaviour {
    //public float speed = 4f; //Velocidad a la que se movera la nave
    Rigidbody2D rb;
	
	[Header("Disparo")]
	public GameObject shot;
	public Transform spawn; 
	public float fireRate;
	private float nextShot;
	public AudioSource audio;

    // Use this for initialization
    void Start() {
        rb = GetComponent<Rigidbody2D>();
    }
	
	// Update is called once per frame
	void Update () {
        //float movX = Input.acceleration.x; //variable que instancia el acelerometro del dispositivo en x
        //float movY = Input.acceleration.y; //variable que instancia el acelerometro del dispositivo en y
        //rb.transform.Translate(Vector2.right * speed * movX * Time.deltaTime); //El comportamiento de como se trasladara el objeto en x
        //rb.transform.Translate(Vector2.up * speed * movY * Time.deltaTime); //El comportamiento de como se trasladara el objeto en y
	    
	    if (Input.GetButton ("Fire1") && Time.time > nextShot) 
	    {
	        nextShot = Time.time + fireRate;
	        Instantiate (shot, spawn.position, Quaternion.identity);
		    audio.Play();	    
	    } 
    }

    private void OnCollisionEnter2D(Collision2D collision) //Aqui persive si la nave tiene alguna colision con algun otro objeto 
    {
        if (collision.gameObject.name == "meteorBrown_big1(Clone)" || collision.gameObject.name == "meteorGrey_big2(Clone)" || collision.gameObject.name == "meteorBrown_med3(Clone)") //Se verifica si la nave choca con un asteroide clonado o cometa clonado
        {
            GameController.instance.vidas --; //Reduce el numero de vidas en 1 cada vez que choca
            if (GameController.instance.vidas == 2) { //Verifica si solo quedan 2 vidas hay que destruir un corazon
                Destroy(GameController.instance.corazon3); //Destruye corazon
            }
            if (GameController.instance.vidas == 1) //Verifica si solo queda 1 vida hay que destruir otro corazon
            {
                Destroy(GameController.instance.corazon2); //Destruye otro corazon
            }
            if (GameController.instance.vidas == 0) { //Termina el juego cuando las vidas son 0
                GameController.instance.gamOver = true;
                SceneManager.LoadScene("Final", LoadSceneMode.Single); //Cambia de scena a la de menu de inicio
                //Application.LoadLevel("Menu"); //Carga la pantalla de inicio al perder
                //Destroy(gameObject);
            }

        }
    }
}
