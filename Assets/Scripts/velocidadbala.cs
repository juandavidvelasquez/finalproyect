using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class velocidadbala : MonoBehaviour 
{
	public Rigidbody bala;
	public float empuje; 


	void Start () 
	{
		bala = GetComponent < Rigidbody > ();
	}

	void Update ()
	{
		bala.velocity = (transform.forward * empuje);
	

	}


}
