using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

// este script sirve para crear un timer dentro del juego y que cuente 100 segundos y al finalizar termine el juego 
public class EjemploTimer : MonoBehaviour
{
    [SerializeField]
    private Text cuentaTiempo;
    [SerializeField]
    private float tiempo = 50;
    
    void Update()// se ejecuta en un update porque es una funcion referente al tiempo y va a moverse durante los fotogramas constantemente 
    {
        if (tiempo > 0)
        {
            tiempo = tiempo- Time.deltaTime ;// deltatime es una variable estatica que se encarga de modificar el tiempo hace que la velocidad de cuadro de su juego sea independiente 
			cuentaTiempo.text = "Tiempo " + tiempo;// si tiempo es mayor que 0, tiempo es igual a tiempo por la variable estatica de unidad de deltatime 

        }
            else
            {
                if(tiempo <= 0)// creamos un estado o condicion if para el tiempo
                {
                    SceneManager.LoadScene(02);//  carga o cambia la escena del juego y simula una finalizacion si el tiempo es igual a 0
                }
            }
            

    }

    }











