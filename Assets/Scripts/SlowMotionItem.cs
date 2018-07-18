using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlowMotionItem : MonoBehaviour {

	float currentAmount = 0f;
float maxAmount = 5f;

	// esta script sirve para hacer camara lenta al tomar el item de la flor de loto 
	void OnTriggerEnter (Collider other) // se activa con un trigger por medio de una colision con el objeto que lo tiene 
	{
		if(other.tag == ("Slowmo"))// por medio de una etiqueta de referencia para que colisione
			{
				if(Time.timeScale == 1.0f)// se crea una condicion if para el tiempo
Time.timeScale = 0.3f;// timescale nos permite manipular la escala de tiempo 

else

Time.timeScale = 1.0f;//Cuando timeScale es 1.0 el tiempo pasa igual de rápido que en la vida real. Cuando timeScale es 0.5 el tiempo pasa el doble de despacio que en la vida real.
Time.fixedDeltaTime = 0.02f * Time.timeScale;// para simular la camara lenta se hace el tiempo mas lento que el tiempo real 
}
// El intervalo en segundos en el que se realizan las actualizaciones físicas y otras velocidades de cuadros fijos
//el fixedDeltaTimeintervalo es con respecto al tiempo en el juego afectado por timeScale

if(Time.timeScale == 0.03f){

currentAmount += Time.deltaTime;
}

if(currentAmount > maxAmount){

currentAmount = 0f;
Time.timeScale = 1.0f;

}

}
}


			
	
