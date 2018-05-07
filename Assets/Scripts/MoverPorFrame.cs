using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoverPorFrame : MonoBehaviour {
	public float distanciaPorSegundo;


	
	// Update is called once per frame
	void Update () {
		 transform.Translate(0, 0, distanciaPorSegundo * Time.deltaTime);
	}
}
