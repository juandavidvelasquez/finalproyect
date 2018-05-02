using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

// se usa para pausar el juego 
public class MenuPausa : MonoBehaviour {

	public bool pausa = false;
	 public Text texto;



	void Start () {
		
	}
	
	// Se ejecuta en update porque se va a usar varias veces
	void Update () 
	{
		if(Input.GetKey(KeyCode.P) && pausa == false)
		{
			pausa = true;
			Time.timeScale = 0;
		
			
		
		}
		else if(Input.GetKey(KeyCode.P)&& pausa == false){
			pausa = false;
			Time.timeScale = 1;
		

		}

		}

		
	}

