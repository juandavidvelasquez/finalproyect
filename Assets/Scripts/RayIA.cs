using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// se usa para hacer que el enemigo se mueva de forma aleatoria hasta encontrar un objeto por medio de un rayo no visible

public class RayIA : MonoBehaviour
{
	public float velocidad;
	public float rango = 5.0f;// se establece un limite 

	
	void Start () {
		
	}
	
	
	void Update () 
	{
		transform.Translate(0,0,velocidad * Time.deltaTime);
		Ray ray = new Ray(transform.position,transform.forward);// se usa para crear el rayo que establecera el limite
		RaycastHit impacto;
		if(Physics.SphereCast(ray ,0.75f,out impacto));
		{
			if(impacto.distance < rango)// se crea una condicion 
			{
				float angulo = Random.Range(-110,110);//se establece un rango aleatorio entre menos 110 y 110
				transform.Rotate(0,angulo,0);
			}
		}
	}
}
