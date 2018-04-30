using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//sirve para instanciar el prefab del  robot enemigo por medio de un navmesh ya bakeado anteriormente  


public class Instanciador : MonoBehaviour
{
    public GameObject robot;
    public Transform[] transformRobot; // se usa para la posicion de donde se hara la instancia 
    public int numSpawn;
    private int numRandom;
    public Navmesh nav;
    public GameObject Target; // objetivo que debe seguir con el navmesh 

    void Update()
    {
        numRandom = Random.Range(0, numSpawn);// un numero aleatorio de clones que instanciara 
        GameObject robotIns = Instantiate(robot, transformRobot[numRandom].position, transform.rotation);


    }
   
}

