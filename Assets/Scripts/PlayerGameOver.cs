using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerGameOver : MonoBehaviour
 {
public GameObject particulas;
	// Se usa para fibnalizar el juego  cuando la esfera colisione con el player 
	void OnTriggerEnter(Collider other)
	{
		if(other.tag == "Player")
		{
			Instantiate (particulas,transform.position,transform.rotation);
			SceneManager.LoadScene(02);
		}
	}
}
