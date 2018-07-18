using System.Collections;
using System.Collections.Generic;
using UnityEngine;


// sirve para hacer que el jugador pueda saltar por medio de gravedad y velocidad al presionar el boton que asignemos 
public class PlayerJump : MonoBehaviour {

	public float  Speed = 10f ;
	public float Jumpforce = 12f;
	private float gravity = 10f ;// se crean variable de velocidad ,gravedad y fuerza de salto y se dan valores enteros 
	private Vector3 moveDi = Vector3.zero;// se crea un vector para las direcciones y el movimiento en los ejes 

// este script hace que el player pueda saltar con la barra espaciadora 
	void Update () 
	{
		CharacterController controller = gameObject.GetComponent<CharacterController> ();// se crea una funcion en update que llame al componente que controla el jugador principal 

		if (controller.isGrounded) {
			moveDi = new Vector3 (Input.GetAxis ("Horizontal"), 0, Input.GetAxis ("Vertical"));// se crea una condicion y por medio de input se definen los movimientos en los axis y los ejes 

			moveDi = transform.TransformDirection (moveDi);

			moveDi *= Speed;

			if (Input.GetButton("Jump")) {// si se presiona el boton jump (barra espaciodora) cumple la condicion 
				moveDi.y = Jumpforce;
			}
		}
		moveDi.y -= gravity * Time.deltaTime;// el movimiento de direccion en el eje es menor o igual a gravedad por tiempo deltatime lo que se significa que la gravedad se reduce al multiplicarse por deltatime y hace que aplique fy¿uerza y velocidad sobre Y y simule un salto 

		controller.Move (moveDi * Time.deltaTime);
	}
}
