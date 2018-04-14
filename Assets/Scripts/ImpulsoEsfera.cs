using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ImpulsoEsfera : MonoBehaviour 
{

	public Rigidbody rocketPrefab;
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