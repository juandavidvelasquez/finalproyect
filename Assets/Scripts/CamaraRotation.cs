using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// se usa para hacer que la camara del juegador pueda rotar de manera vertical y horizontal 

public class CamaraRotation : MonoBehaviour {

 public float speedH = 2.0f;
    public float speedV = 2.0f;

    private float rota = 0.0f;
    private float inclina = 0.0f;



    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
// con input y asignando los axis  se de la el movimiento con el mouse a camara
        rota += speedH * Input.GetAxis("Mouse X");
       inclina -= speedV * Input.GetAxis("Mouse Y");

        transform.eulerAngles = new Vector3(inclina, rota, 0.0f);// se usa para dar una representacion por medio de un vector3 a X,Y,Z y euler a su rotcion

    }
}