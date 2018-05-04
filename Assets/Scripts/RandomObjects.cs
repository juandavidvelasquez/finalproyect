using System.Collections;
using System.Collections.Generic;
using UnityEngine;
// el script sirve para instanciar item en una posicion aleatoria
public class RandomObjects : MonoBehaviour {

	public Vector3[] posicion;


	void Start ()
	 {
		 int RandomNum = Random.Range(0,posicion.Length);
		 transform.position = posicion[RandomNum];
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
