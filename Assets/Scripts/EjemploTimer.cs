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
    
    void Update()
    {
        if (tiempo > 0)
        {
            tiempo = tiempo- Time.deltaTime ;
			cuentaTiempo.text = "Tiempo " + tiempo;
        }
            else
            {
                if(tiempo <= 0)
                {
                    SceneManager.LoadScene(02);
                }
            }
            

    }

    }











