using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerGameOver : MonoBehaviour
 {
public GameObject particulas;
	// Se usa para finalizar el juego  cuando la esfera colisione con el player y simule que murio o perdio 
	void OnTriggerEnter(Collider other)// se crea una funcion en un trigger para que active la condicion ya que es una esfera que colisiona con objetos
	{
		if(other.tag == "Player")// se da una etiqueta como referencia para el objeto de juego 
		{
			Instantiate (particulas,transform.position,transform.rotation);// se crea una instancia de particulas que simule una explosion y una muerte del player 
			SceneManager.LoadScene(02);// se carga la siguiente escena 
		}
	}
}
