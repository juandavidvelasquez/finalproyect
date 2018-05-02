using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Exit : MonoBehaviour {

	// Se usa para salir del el juego en la interface del menu del juego 
//se crea un metodo para clickear el boton de salida del juego 
void OnMouseDown()

{
	if(Input.GetMouseButtonDown(0))
	{
		Application.Quit();
		Debug.Log("Has Salido del juego");
	}
}
}