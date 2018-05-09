using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Trigger : MonoBehaviour {
// este script sirve para activar la clase que permite retroceder el tiempo al tomar el item de la rosa 
	public Text texto;
	void OnTriggerEnter(Collider col)
	{
		if(col.tag == ("Rose"))
		{
			Instantiate (texto,transform.position,transform.rotation);
			GetComponent<RosaItem>();
		}else{
			if(Input.GetKey(KeyCode.E))
			{
				Destroy(texto);
				Destroy(gameObject);
			}
		}

	}
}
