using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//Autores Rodrigo Samayoa y David Soto

public class Disparo : MonoBehaviour {

	private Rigidbody2D rig;
	public float speed;


	void Awake()
	{
		rig = GetComponent<Rigidbody2D> ();
	}


	// Use this for initialization
	void Start () 
	{
		rig.velocity = transform.up * speed;
	}

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name == "meteorBrown_big1(Clone)") //Condicion para desaparecer los asteroides
        {
            Destroy(gameObject); //Destruye el asteroide
            //Debug.Log(collision.gameObject.name);
        }
    }
}
