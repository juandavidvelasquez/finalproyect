using System.Collections;
using System.Collections.Generic;
using UnityEngine;
// se usa para mover los carros cada frame y simular que se mueven y transitan al rededor del juego 

public class MoverPorFrame : MonoBehaviour {
	public float distanciaPorSegundo;


	
	// se ejecuta en update porque se movera cada distancia por segundos en cada fotograma
	void Update () {
		 transform.Translate(0, 0, distanciaPorSegundo * Time.deltaTime);//se traslada en z cada frame multiplicado por deltatime y la distancia por segundo
	}
}
