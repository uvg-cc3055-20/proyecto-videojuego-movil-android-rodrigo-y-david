using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//Autores Rodrigo Samayoa y David Soto

public class Ship : MonoBehaviour {
    public float speed = 2f; //Velocidad a la que se movera la nave
    Rigidbody2D rb;

    // Use this for initialization
    void Start() {
        rb = GetComponent<Rigidbody2D>();
    }
	
	// Update is called once per frame
	void Update () {
        float movX = Input.acceleration.x; //variable que instancia el acelerometro del dispositivo
        rb.transform.Translate(Vector2.right * speed * movX * Time.deltaTime); //El comportamiento de como se trasladara el objeto
    }

    private void OnCollisionEnter2D(Collision2D collision) //Aqui persive si la nave tiene alguna colision con algun otro objeto 
    {
        if (collision.gameObject.name == "meteorBrown_big1(Clone)") //Se verifica si la nave choca con un asteroide clonado
        {
            GameController.instance.gamOver = true;
            Application.LoadLevel("Menu"); //Carga la pantalla de inicio al perder
            //Destroy(gameObject);
        }
    }
}
