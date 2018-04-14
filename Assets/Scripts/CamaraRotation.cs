﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

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

        rota += speedH * Input.GetAxis("Mouse X");
       inclina -= speedV * Input.GetAxis("Mouse Y");

        transform.eulerAngles = new Vector3(inclina, rota, 0.0f);

    }
}