using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//Autores Rodrigo Samayoa y David Soto

public class PiedritaBehaviour : MonoBehaviour {
    public float speed = 12f;
    Rigidbody2D rb;
    // Use this for initialization
    void Start () {
        rb = GetComponent<Rigidbody2D>();
    }
	
	// Update is called once per frame
	void Update () {
        rb.transform.Translate(Vector2.down * speed * Time.deltaTime); //Forma en que se desplazaran las piedritas
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name == "laserBlue12 (2)" || collision.gameObject.name == "Disparo(Clone)" || collision.gameObject.name == "playerShip1_orange") //Condicion para desaparecer las piedritas
        {
            Destroy(gameObject); //Destruye la piedrita
            //Debug.Log(collision.gameObject.name);
        }
    }
}
