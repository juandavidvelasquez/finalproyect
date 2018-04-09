using UnityEngine;
using System.Collections;

public class Moveplayer: MonoBehaviour 
{
	public float speed = 10.0F;
	public float rotationSpeed = 100.0F;
    public  bool elPique;

	void Update() {
		float translation = Input.GetAxis("Vertical") * speed;
		float rotation = Input.GetAxis("Horizontal") * rotationSpeed;
		translation *= Time.deltaTime;
		rotation *= Time.deltaTime;
		transform.Translate(0, 0, translation);
		transform.Rotate(0, rotation, 0);

        if (Input.GetKeyDown("space"))
        {
            speed = Input.GetAxis("Vertical") * speed * 2;
            print("Se Presiono Espacio ");
            elPique = true;
            if (elPique = false)

            {

            }
            

        }
        
	}
}
