using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

// se usa para darle movimiento y inteligencia artificial al enemigo  por medio de un navmesh
public class Follower : MonoBehaviour
{
	[SerializeField] Transform target; //  un objetivo a seguir
	 NavMeshAgent agent ; 
	[SerializeField] float  UpdateDelay = .3f ;
	public Transform mirar;

	void Awake()
	{
		agent = GetComponent<NavMeshAgent> ();// se hace un llamado al componente de navegacion de navmesh 
	}
		


	void Update ()
	{
		agent.SetDestination (target.position);// se crea un destino y una posicion 
	}
}



  