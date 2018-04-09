using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

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
            print(tiempo);
			cuentaTiempo.text = "Tiempo " + tiempo;
        }

    }
}









