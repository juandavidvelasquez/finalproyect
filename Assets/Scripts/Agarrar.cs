using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Agarrar : MonoBehaviour {

public GameObject selected; //esta variable guarda el gameobject seleccionado

	void Update () {
		
		if(Input.GetButton("Fire2"))//Cuando haces click con el mouse izq
		{	
			
			if(selected==null)selected=Raycast();//Si la variable selected es null agregara el gameobject seleccionado
			else if(selected!=null || selected == Raycast()) selected = null;//Si ya hay uno seleccionado lo desselecciona.
		}
		if(selected!=null)
		{ //Mientras el seleccionado no sea null lo movera con el mouse
			Vector3 safeZ = Mpos();
			safeZ.z = selected.transform.position.z;
			selected.transform.position = safeZ;
		}
	}

	GameObject Raycast ()//Retorna un raycast, si no se hace click en un object retornara null
	{
		RaycastHit vHit = new RaycastHit();
         Ray vRay = Camera.main.ScreenPointToRay(Input.mousePosition);
         if(Physics.Raycast(vRay, out vHit, 1000)) 
         {
             return vHit.transform.gameObject;
         }
		 return null;
	}
	Vector3 Mpos () //Retorna la posicion del mouse
	{
		 Vector3 v3 = Input.mousePosition;
			v3.z = 10.0f;
			v3 = Camera.main.ScreenToWorldPoint(v3);
         return v3;
	}
}