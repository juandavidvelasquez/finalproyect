using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Destroyer : MonoBehaviour {

	[SerializeField]
	private int contador;
	public Text puntuacion;
	public GameObject explosion;



	void OnTriggerEnter(Collider other)
	{
		if (other.tag == "Enemy")
			Instantiate(explosion, transform.position,transform.rotation);
			contador = contador + 10;
		puntuacion.text = "Puntuacion: " + contador;

			{
			Destroy(other.gameObject);

		}
	}

	void Awake()
	{
		contador = 0;
		print (contador);
		puntuacion.text = "Puntuacion: " + contador;
	}

}