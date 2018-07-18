using System.Collections;
using System.Collections.Generic;
using UnityEngine;
// el script sirve para instanciar item en una posicion aleatoria y que no siempre esten en los mismos lugares para variar 
public class RandomObjects : MonoBehaviour {

	public Vector3[] posicion;// se crea un vector3 para las diferentes posiciones aleatorias x,y,z y un array pa que cree una lista de las posiciones 

// se ejecuta una sola vez cada comienzo del juego
	void Start ()
	 {
		 int RandomNum = Random.Range(0,posicion.Length);// se crea un rango aleatorio y una distancia y pocision aleatoria para el objeto 
		 transform.position = posicion[RandomNum];
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
