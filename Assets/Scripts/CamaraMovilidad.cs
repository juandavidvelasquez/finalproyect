using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamaraMovilidad : MonoBehaviour {

	public Camera camara;// se crea una variable   tipo camara  y otras para definir las direcciones y las velocidad en que se va a mover

	public float horizontalSpeed;

	public float verticalSpeed;

	float h;

	float v;

	void Start () {
		
	}
	
	// se ejecuta en el metodo update por que se usa en la movilidad del personaje y la camara y se estan moviendo simultaneamente varias veces por fotograma 
	void Update () 
	{
		h = horizontalSpeed * Input.GetAxis("Mouse X");// las direcciones son iguales a la velocidad por la direccion del mouse que se ejecuta por medio de input 
		v = verticalSpeed * Input.GetAxis("Mouse Y");

		transform.Rotate(0,h,0);// transform sirve para manipular la pocision,rotacion y escala de un objeto en este caso lo usamos para rotacion de la camara en los ejes 
		camara.transform.Rotate(-v,0,0);//aplica una rotación de eulerAngles.zgrados alrededor del eje z, eulerAngles.xgrados alrededor del eje x y eulerAngles.y grados alrededor del eje Y 

		if(Input.GetKey(KeyCode.W)){  // se crean condiciones if y un else ,en un input se asigna una tecla de los axis para trasladarse  en diferentes direcciones por medio de un transform 
		transform.Translate(0,0,0.1f);
		}else{
			if(Input.GetKey(KeyCode.S)){
				transform.Translate(0,0,-0.1f);
			}else{
				if(Input.GetKey(KeyCode.A)){
					transform.Translate(-0.1f,0,0);
					}else{
						if(Input.GetKey(KeyCode.D)){
							transform.Translate(0.1f,0,0);//  se agregan valores de movimiento de velocidad en cada direccion si se presiona cada una de las teclas que asignamos  
						}
					}
				}
			}
				

				
			}

		}
	

