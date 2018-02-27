using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//Autores Rodrigo Samayoa y David Soto

public class movimientoNave : MonoBehaviour {

// En esta variable configuraremos la velocidad a la que se moverá el objeto
    public float Velocidad = 5.0F;
 
    private bool derecha;
    private bool izquierda;
 
    void Update ()
    {
        if(Input.GetButton ("Fire1") && derecha)
        {
            // Movemos el objeto hacia la derecha
            this.transform.Translate(Vector3.right * Time.deltaTime * Velocidad);
        }
 
        if (Input.GetButton ("Fire1") && izquierda)
        {
            // Movemos el objeto hacia la izquierda
            this.transform.Translate(Vector3.left * Time.deltaTime * Velocidad);
        }
    }
 
    /******************** FUNCIONES PÚBLICAS ********************/
 
    public void MoverDerecha()
    {
        derecha = true; //Movimiento a la derecha
    }
 
    public void MoverIzqda()
    {
        izquierda = true; //Movimiento a la izquierda
    }
    
    public void MoverDere()
    {
        derecha = false; //Movimiento a derecha
    }
 
    public void MoverIzquierda() //Movimiento a la izquierda
    {
        izquierda = false;
    }
}
