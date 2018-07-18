using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

// se usa para pausar el juego 
public class MenuPausa : MonoBehaviour {
// se crea una variable de tipo bool (verdadero o falso) en el que se activa la pausa y se asigna como falsa porque no se ha activado la tecla de pausa.

	public bool pausa = false;
	 public Text texto;



	void Start () {
		
	}
	
	// Se ejecuta en update porque se va a usar constantemente durante el juego y se va a repetir la presion de la tecla para ativar o desactivar.
	void Update () 
	{
		if(Input.GetKey(KeyCode.P) && pausa == false)// por medio de input se agrega una funcion para la tecla.
		{
			pausa = true;
			Time.timeScale = 0;//Cuando timeScale se establece en cero, el juego se detiene básicamente si todas sus funciones son independientes de la frecuencia de cuadros y simula una pausa del juego. 
		
			
		
		}
		else if(Input.GetKey(KeyCode.P)&& pausa == false){
			pausa = false;
			Time.timeScale = 1; //Cuando timeScalees 1.0, el tiempo pasa tan rápido como en tiempo real y vuelve a su tiempo tiempo normal dentro del juego.
		

		}

		}

		
	}

