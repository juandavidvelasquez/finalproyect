using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Navmesh : MonoBehaviour
{
	void Start()
	{
		GameObject Vase = GameObject.Find("Base");
		GetComponent<NavMeshAgent>().destination = Vase.transform.position;
 	}

  }