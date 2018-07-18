using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Trigger : MonoBehaviour {
// este script sirve para activar la clase que permite tener una simulacion de  retroceder el tiempo al tomar el item de la rosa esta clase hereda de otro script
	public Text texto;
	void OnTriggerEnter(Collider col)
	{
		if(col.tag == ("Rose"))// asignamos una etiqueta como referencia al colisionar con el jugador si cumple la condicion 
		{
			Instantiate (texto,transform.position,transform.rotation);
			GetComponent<RosaItem>();// se busca el script que deñ que hereda como componente par que llame las funciones de el otro script
		}else{
			if(Input.GetKey(KeyCode.E))// asigamos un boton que nos permita ejecutar la funcion
			{
				Destroy(texto);
				Destroy(gameObject);
			}
		}

	}
}
