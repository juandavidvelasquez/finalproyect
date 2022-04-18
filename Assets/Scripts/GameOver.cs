using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
// este script simula una finalizacion del juego si la el objeto esfera sale del rango de juego 
public class GameOver : MonoBehaviour {

public GameObject sfera;// se crea una variable publica para asignar el objeto 



	void OnTriggerEnter(Collider other)// se crea un trigger o un gatillo para activar la funcion de el cambio de escena por medio de una colision 
	{
		
		if(other.GetComponent<Collider>().tag == "Out")// se asigna una etiqueta como referencia del objeto que al colisionar realizara la funcion 
		{
			SceneManager.LoadScene (02);// cambia o carga de escena en este cado la que escena que fue marcada como #2 en el editor de unity 
		
}
}
}

