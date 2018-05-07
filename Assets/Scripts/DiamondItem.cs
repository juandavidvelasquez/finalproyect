using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DiamondItem : MonoBehaviour {

// este script sirve para dar funcion al skill del item diamante 
	public Transform destinoTrigger;

	
	void OnTriggerEnter(Collider col) 
	{
		if(col.transform.name == "jugador")
		{
			Vector3 newPos = destinoTrigger.position;
			newPos.y = col.transform.position.y;
			col.transform.position = newPos;
			// se crea una nueva pocision 
		}
	
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
