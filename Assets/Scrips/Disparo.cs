using System.Collections;
using System.Collections.Generic;
using UnityEngine;

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
}
