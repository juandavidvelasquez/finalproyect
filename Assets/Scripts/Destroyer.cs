using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

// se usa para destruir objetivos y npc por medio de colisiones y agregador puntos al marcador luego de ser destruidos 

public class Destroyer : MonoBehaviour {

	[SerializeField]// serializar, permite ver las variables privadas en el inspector de unity 
	private int contador;
	public Text puntuacion;
	public GameObject explosion;



	void OnTriggerEnter(Collider other)// se usa un trigger para detectar la colision y activar el collider del objeto 
	{
		if (other.tag == "Enemy")// se crea una etiqueta de tipo enemy para que al tocar cada objeto con esa etiqueta se instancie la explosion y se destruya el objetivo 
			Instantiate(explosion, transform.position,transform.rotation);
			contador = contador + 10;// se  crea un contador y se establece la suma de puntos 
		puntuacion.text = "Puntuacion: " + contador;
        GetComponent<AudioSource>().Play();// se crea un componente para el audio para que suene una explosion cada que toque el objetivo con esa etiqueta
        {	
			// se destruye el objeto al colisionar 
			
			Destroy(other.gameObject);

		
		}
	}

	// se crea un metodo awake para modificar el contador cada que la funcion y la instancia sean realizadas 
		void Awake()
	{
		contador = 0;
		print (contador);
		puntuacion.text = "Puntuacion: " + contador;
	}

}
	