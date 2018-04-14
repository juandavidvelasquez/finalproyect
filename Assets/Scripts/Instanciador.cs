using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Instanciador : MonoBehaviour
{
    public GameObject robot;
    public Transform[] transformRobot;
    public int numSpawn;
    private int numRandom;
    public Navmesh nav;
    public GameObject Target;

    void Update()
    {
        numRandom = Random.Range(0, numSpawn);
        GameObject robotIns = Instantiate(robot, transformRobot[numRandom].position, transform.rotation);


    }
   
}

