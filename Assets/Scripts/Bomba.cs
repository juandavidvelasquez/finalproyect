using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// sirve para crear una bomba con contador que hace que explote la esfera y luego se instancie otra 
public class Bomba : MonoBehaviour {

	public float tiempo = 5;

	public GameObject bomb;

	public GameObject prefab;



	void Start () 
	{
		
	}
	
	
	void Update () 
	{
		tiempo -= Time.deltaTime;
		if(tiempo <= 0)
		{
			AutoDestroy();

		}
	}

	void AutoDestroy()
	{
		if(bomb != null)
		{
			Instantiate(bomb,transform.position, transform.rotation);

		}
		Destroy(gameObject);

		Instantiate(prefab,transform.position,transform.rotation);
		

	}

	
	}

