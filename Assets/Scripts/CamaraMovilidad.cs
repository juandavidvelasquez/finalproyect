using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamaraMovilidad : MonoBehaviour {

	public Camera camara;

	public float horizontalSpeed;

	public float verticalSpeed;

	float h;

	float v;

	void Start () {
		
	}
	
	// se ejecuta en el metodo update porque siempre va a ser repetido
	void Update () 
	{
		h = horizontalSpeed * Input.GetAxis("Mouse X");
		v = verticalSpeed * Input.GetAxis("Mouse Y");

		transform.Rotate(0,h,0);
		camara.transform.Rotate(-v,0,0);

		if(Input.GetKey(KeyCode.W)){
		transform.Translate(0,0,0.1f);
		}else{
			if(Input.GetKey(KeyCode.S)){
				transform.Translate(0,0,-0.1f);
			}else{
				if(Input.GetKey(KeyCode.A)){
					transform.Translate(-0.1f,0,0);
					}else{
						if(Input.GetKey(KeyCode.D)){
							transform.Translate(0.1f,0,0);
						}
					}
				}
			}
				

				
			}

		}
	

