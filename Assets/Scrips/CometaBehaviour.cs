using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Effects;

//Autores Rodrigo Samayoa y David Soto

public class CometaBehaviour : MonoBehaviour {
    public float speed = 10f;
    Rigidbody2D rb;
    public GameObject particulas;
    // Use this for initialization
    void Start () {
        rb = GetComponent<Rigidbody2D>();
    }
	
	// Update is called once per frame
	void Update () {
        rb.transform.Translate(Vector2.down * speed * Time.deltaTime); //Forma en que se desplazaran los cometas
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name == "laserBlue12 (2)" || collision.gameObject.name == "Disparo(Clone)" ||
            collision.gameObject.name == "playerShip1_orange") //Condicion para desaparecer los cometas
        {
            Instantiate(particulas, new Vector3(gameObject.transform.position.x, gameObject.transform.position.y, gameObject.transform.position.z), Quaternion.identity); //se instancian las particulas
            Destroy(gameObject); //Destruye el cometa
            //Debug.Log(collision.gameObject.name);
        }
    }
}
