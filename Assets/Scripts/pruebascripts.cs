using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pruebascripts : MonoBehaviour {

	public static Transform[] points;// se crea un array o lista de puntos 
// se hace en awake porque se ejecutara una vez cada que llame la funcion 
	void Awake () 
	{
		points = new Transform[transform.childCount];// cuentalos nuevos objetos hijos de puntos 
		for (int i = 0; i < points.Length; i++) 
		{
			points [i] = transform.GetChild (i);//Devuelve un  objeto hijo de transformación por índice
		}
	}
}
