using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//este script sirve para darle fuerza y movimiento a la esfera para que pueda colisionar por medio del click izquierdo
public class ImpulsoEsfera : MonoBehaviour 
{

	public Rigidbody rocketPrefab;// se usa un rigidbody para darle fuerza al objeto
	public GameObject Activar;// se crea una variable para el objeto del juego 

	public void Start()
	{
		Activar.SetActive (false);// se crea una variable bool para activar o desactivar el boton con el click derecho
	}

	void Update ()
	{
		if (Input.GetButtonDown ("Fire1")) {// se crea una condicion para ejectuar el click a través de input
			Activar.SetActive (true);
			rocketPrefab.AddForce (transform.forward * 3000);// se le agrega fuerza por medio del rigidbody al transform en direccion frontal en el eje z y se multiplica por el valor de fuerza que quiera


		} else 
		{
			Activar.SetActive (false);// si el click no esta presionado el rigidbody dejarade aplicar fuerza 
		}
	}
}