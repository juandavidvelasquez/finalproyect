using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

// se usa para destruir objetivos y npc por medio de colisiones y agregador puntos al marcador luego de ser destruidos 

public class Destroyer : MonoBehaviour {

	[SerializeField]
	private int contador;
	public Text puntuacion;
	public GameObject explosion;



	void OnTriggerEnter(Collider other)// se usa un trigger para detectar la colision y activar el collider del objeto 
	{
		if (other.tag == "Enemy")
			Instantiate(explosion, transform.position,transform.rotation);
			contador = contador + 10;// se  crea un contador y se establece la suma de puntos 
		puntuacion.text = "Puntuacion: " + contador;
        GetComponent<AudioSource>().Play();
        {
			Destroy(other.gameObject);// de destruye el objeto al colisionar 

		}
	}

	void Awake()
	{
		contador = 0;
		print (contador);
		puntuacion.text = "Puntuacion: " + contador;
	}

}