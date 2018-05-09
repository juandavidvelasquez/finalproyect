using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RosaItem : MonoBehaviour {
	// este script sirve para simular que retrocede en el tiempo tomando las posiciones por las que transito el jugador 
	
  private ArrayList Movements = new ArrayList();
     private int MovementIndex = 0;
     private bool rewinding;
 
     void Update ()
     {
         if (!rewinding){
             Movements.Add(transform.position);
             MovementIndex++;
         }
 
         if(MovementIndex > Movements.Count - 1) {
             MovementIndex = Movements.Count;
         }
 
         if(Input.GetKey("e")) {
             rewinding = true;
             RewindTime();
         } else {
             rewinding = false;
         }
     }
 
     void RewindTime ()
     {
         MovementIndex--;
         if (MovementIndex > 0) {
             transform.position = (Vector3) Movements[MovementIndex];
             Movements.RemoveAt(MovementIndex);
         }
     }
}

	
	
