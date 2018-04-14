using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOver : MonoBehaviour {




void Start(){

}

	void OnTriggerEnter(Collider other)
	{
		
		if(other.tag == "Out");
		print("Out Of Range");
	
}
}

