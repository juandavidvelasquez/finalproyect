using System.Collections;
using System.Collections.Generic;
using UnityEngine;
// sirve para simular la inteligencia artifial del movimiento de los coches  
public class Coches : MonoBehaviour {
	public float speed;
	public Transform target;

	void Start () {
			transform.LookAt(new Vector3(target.position.x,target.position.y,target.position.z));
	}
	
	
	void Update () 
	{
		transform.Translate(new Vector3(0,0,Time.deltaTime));

	}

void OnTriggerEnter(Collider other)
{
	if(other.tag == "Waypoint")
	{
		target = other.gameObject.GetComponent<Waypoint>().nuevoPunto;
		transform.LookAt(new Vector3(target.position.x,transform.position.y,target.position.z));

	}

}

}

