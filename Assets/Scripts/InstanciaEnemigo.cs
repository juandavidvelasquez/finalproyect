using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InstanciaEnemigo : MonoBehaviour {

	public GameObject  enemy;
	
	void OnCollisionEnter(Collision otherObj) {
    if (otherObj.gameObject.tag == "Enemy")
	{
		Destroy(gameObject,.5f);
		Start();
	}
	}
	
	void Start ()
	{
		 for (int i = 0; i < 5; i++) {
        Instantiate(enemy);
	}
	}
}
	


