using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
// este script simula un nuevo intento del nivel de juego por medio de un cambio de escena si pierde
public class TryAgain : MonoBehaviour {
public  GameObject texto;
	
	void Start () {
		
	}

	void Update () 
		{
			Instantiate(texto,transform.position,transform.rotation);// se crea uba instancia de un texto como menu de volver a jugar 
		}

		void Cambio()// creamos una funcion con input para presionar un boton que nos permita volver a comenzar luego de perder
		{
			if(Input.GetButton("Enter"))// se crea una condicion que si presiona la tecla que asginamos en input activara el scenemanager que sirve para manipular el editor de escenas
			{
				SceneManager.LoadScene(01);

			}
		}
}
			
			

			

		

	

	
