using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//Autores Rodrigo Samayoa y David Soto

public class Disparo : MonoBehaviour {

	private Rigidbody2D rig;
	public float speed;


	void Awake()
	{
		rig = GetComponent<Rigidbody2D> (); //Componente rigido del disparo
	}


	// Use this for initialization
	void Start () 
	{
		rig.velocity = transform.up * speed; //Velocidad del disparo
	}

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name == "meteorBrown_big1(Clone)"|| collision.gameObject.name == "laserBlue12 (3)" || collision.gameObject.name == "meteorGrey_big2(Clone)" || collision.gameObject.name == "meteorBrown_med3(Clone)") //Condicion para desaparecer los disparos
        {
            Destroy(gameObject); //Destruye el disparo
        }
    }
}
