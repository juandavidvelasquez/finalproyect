using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TryAgain : MonoBehaviour {
public  GameObject texto;
	
	void Start () {
		
	}

	void Update () 
		{
			Instantiate(texto,transform.position,transform.rotation);
		}

		void Cambio()
		{
			if(Input.GetButton("Enter"))
			{
				SceneManager.LoadScene(01);

			}
		}
}
			
			

			

		

	

	
