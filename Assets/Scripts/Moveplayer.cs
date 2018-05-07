using UnityEngine;
using System.Collections;


// movimiento de traslacion jugador principal y velocidad 
public class Moveplayer: MonoBehaviour 
{
	public float speed = 10.0F;
	public float rotationSpeed = 100.0F;
    public  bool elPique;

	void OnTriggerEnter(Collider other) {
		float translation = Input.GetAxis("Vertical") * speed;
		float rotation = Input.GetAxis("Horizontal") * rotationSpeed;
		translation *= Time.deltaTime;
		rotation *= Time.deltaTime;
		transform.Translate(0, 0, translation);
		transform.Rotate(0, rotation, 0);

     
        if (other.tag == "Llave")
        {
            speed = Input.GetAxis("Vertical") * speed * 2;
            print("Se Presiono Espacio ");
            elPique = true;
            if (elPique == false) 

            {
                speed = 1.0f;
            }
            

        }
        
	}
}
