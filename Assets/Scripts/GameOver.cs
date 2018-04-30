using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour {

public GameObject sfera;



	void OnTriggerEnter(Collider other)
	{
		
		if(other.GetComponent<Collider>().tag == "Out")
		{
			SceneManager.LoadScene (02);
		
}
}
}

