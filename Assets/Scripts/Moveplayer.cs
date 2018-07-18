using UnityEngine;
using System.Collections;


// Item de incremento de velocidad del jugador 
public class Moveplayer: MonoBehaviour 
{
	public float speed = 10.0F;
	public float rotationSpeed = 100.0F;
    public  bool elPique;// se crea una variable de tipo bool para activar el incremento de velocidad si es verdadero o reducirlo si es falso 

	void OnTriggerEnter(Collider other) {// se crea un trigger que al colisionar active la funcion 
		float translation = Input.GetAxis("Vertical") * speed;
		float rotation = Input.GetAxis("Horizontal") * rotationSpeed;
		translation *= Time.deltaTime;
		rotation *= Time.deltaTime;
		transform.Translate(0, 0, translation);
		transform.Rotate(0, rotation, 0);

     
        if (other.tag == "Llave")// si colisiona con el objeto que tiene la etiqueta llave la velocidad se va a multiplicar por 2 
        {
            speed = Input.GetAxis("Vertical") * speed * 2;
            print("Se Presiono Espacio ");
            elPique = true;
            if (elPique == false) 

            {
                speed = 1.0f;// si la variable es falsa volvera a la velocidad normal 
            }
            

        }
        
	}
}
