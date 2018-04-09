using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Follower : MonoBehaviour
{
	[SerializeField] Transform target;
	 NavMeshAgent agent ;
	[SerializeField] float  UpdateDelay = .3f ;
	public Transform mirar;

	void Awake()
	{
		agent = GetComponent<NavMeshAgent> ();
	}
		


	void Update ()
	{
		agent.SetDestination (target.position);
	}
}



  