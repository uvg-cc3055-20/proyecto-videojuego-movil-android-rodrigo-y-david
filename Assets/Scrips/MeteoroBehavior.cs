using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//Autores Rodrigo Samayoa y David Soto

public class MeteoroBehavior : MonoBehaviour {
    public float speed = 6f;
    Rigidbody2D rb;
    public GameObject particulas;
    public AudioSource audio;
    // Use this for initialization
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }
    // Update is called once per frame
    void Update()
    {
        rb.transform.Translate(Vector2.down * speed * Time.deltaTime); //Forma en que se desplazaran los asteroides
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.name == "Disparo(Clone)" || collision.gameObject.name == "playerShip1_orange") //Condicion para desaparecer los asteroides
        {
            Instantiate(particulas, new Vector3(gameObject.transform.position.x, gameObject.transform.position.y, gameObject.transform.position.z), Quaternion.identity); //se instancian las particulas
            Instantiate(audio, new Vector3(gameObject.transform.position.x, gameObject.transform.position.y, gameObject.transform.position.z), Quaternion.identity);
            //audio.Play();
            Destroy(gameObject); //Destruye el asteroide
            //Debug.Log(collision.gameObject.name);
        }

        if (collision.gameObject.name == "laserBlue12 (2)")
        {
            Destroy(gameObject); //Destruye el asteroide
        }
    }
}
