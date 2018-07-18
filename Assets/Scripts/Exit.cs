using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Exit : MonoBehaviour {

	// Se usa para salir del el juego en la interface del menu del juego 
//se crea un metodo para clickear el boton de salida del juego 
void OnMouseDown()

{
	if(Input.GetMouseButtonDown(0))//  en input al clickear el texto del menu de juego que dice salir
	{
		Application.Quit();// se sale de la aplicación del jugador,Apaga la aplicación en ejecución. Salir es ignorado en el editor.


		Debug.Log("Has Salido del juego");
	}
}
}