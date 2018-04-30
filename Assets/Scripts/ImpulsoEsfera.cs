using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//este script sirve para darle fuerza y movimiento a la esfera para que pueda colisionar por medio del click izquierdo
public class ImpulsoEsfera : MonoBehaviour 
{

	public Rigidbody rocketPrefab;// se usa un rigidbody para darle fuerza al objeto
	public GameObject Activar;

	public void Start()
	{
		Activar.SetActive (false);
	}

	void Update ()
	{
		if (Input.GetButtonDown ("Fire1")) {
			Activar.SetActive (true);
			rocketPrefab.AddForce (transform.forward * 3000);

		} else 
		{
			Activar.SetActive (false);
		}
	}
}