using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RosaItem : MonoBehaviour {
	// este script sirve para simular que retrocede en el tiempo tomando las posiciones por las que transito el jugador 
	
  private ArrayList Movements = new ArrayList();// se crea una lista array para que guerde las posiciones que recorrio 
     private int MovementIndex = 0;
     private bool rewinding;// se crea un bool para activar o desactivar la funcion de rebobinar el tiempo 
 
     void Update ()
     {
         if (!rewinding){
             Movements.Add(transform.position);// se crea una condicion que agregue las posiciones por medio de un transform 
             MovementIndex++;
         }
 
         if(MovementIndex > Movements.Count - 1) {// se crea un indice y un contador para los movimientos 
             MovementIndex = Movements.Count;
         }
 
         if(Input.GetKey("e")) {// se asigna una tecla para activar o desactivar la funcion
             rewinding = true;// si es verdadero llamara la funcion
             RewindTime();
         } else {
             rewinding = false;// si vuelve a presionar la tecla asignada una vez activado se desactiva
         }
     }
 
     void RewindTime ()
     {
         MovementIndex--;
         if (MovementIndex > 0) {
             transform.position = (Vector3) Movements[MovementIndex];// para  manipular y guardar las posiciones que recorrio  usamos un vector3 
             Movements.RemoveAt(MovementIndex);
         }
     }
}

	
	
