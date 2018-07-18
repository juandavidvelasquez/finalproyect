using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DiamondItem : MonoBehaviour {

// este script sirve para dar funcion al objeto item diamante que tiene como skill simular una teleportacion del jugador 
	public Transform destinoTrigger;

	
	void OnTriggerEnter(Collider col) 
	{
		if(col.transform.name == "jugador")// si tiene el nombre jugador al colisionar con el objeto 
		{
			Vector3 newPos = destinoTrigger.position;
			newPos.y = col.transform.position.y;
			col.transform.position = newPos;
			// se crea una nueva posicion y se activa el trigger para que el jugador se mueva en la nueva direccion que se crea 
		}
	
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
