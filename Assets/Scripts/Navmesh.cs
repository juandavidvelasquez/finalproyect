using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;// esta libreria de unity se usa para la inteligencia artificial ,pathfinders y navmesh
// este script es de navmesh para simular el movimiento de los robots y que sigan un target
public class Navmesh : MonoBehaviour
{
	void Start()
	{
		GameObject Vase = GameObject.Find("Base");// la base es el objetivo al que debe seguir el navmesh 
		GetComponent<NavMeshAgent>().destination = Vase.transform.position;// se crea un componente agente para que busque un objetivo como destino que es igual a la posicion donde estara la base o objetivo
 	}

  }