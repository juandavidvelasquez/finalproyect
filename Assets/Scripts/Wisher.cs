using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Wisher : MonoBehaviour {

	public float timer;
	public int newTarget;
	public float speed;
	public  NavMeshAgent nav;
	public Vector3 Target ;

	void Start ()
	{
		nav = gameObject.GetComponent<NavMeshAgent>();
	}



	void Update () 
	{
		timer += Time.deltaTime;

		if(timer >=  newTarget)
		{
			newtarget();
			timer = 0;
		}
	}
	void newtarget()
	{
		float myX = gameObject.transform.position.x;
		float myZ = gameObject.transform.position.z;
        float xYz = gameObject.transform.forward.z;
		float Xpos = myX + Random.Range (myX - 100,myX + 100);
		float Zpos = myZ + Random.Range ( myZ- 100,myZ + 100);

			Target = new Vector3 (Xpos,gameObject.transform.position.y,Zpos);

			nav.SetDestination (Target);
			}
			}

