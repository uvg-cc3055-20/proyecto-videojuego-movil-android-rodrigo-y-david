using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Disparo : MonoBehaviour {

	private Rigidbody rig;
	public float speed;


	void Awake()
	{
		rig = GetComponent<Rigidbody> ();
	}


	// Use this for initialization
	void Start () 
	{
		rig.velocity = transform.forward * speed;
	}
}
