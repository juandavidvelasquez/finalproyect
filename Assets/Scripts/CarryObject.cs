using UnityEngine;
using System.Collections;
// este script simula que agarra objetos por medio de telekinesis 
public class CarryObject : MonoBehaviour
{
    public float interactDistance = 3;
    public float carryDistance = 2.5f;
    public LayerMask interactLayer;

    private Transform carryObject;// se usa transform el transform de cada objeto para poderlo mover 
    private bool haveObject;

    void Update()
    {
        //variables del raycast.
        Ray ray = new Ray(Camera.main.transform.position, Camera.main.transform.forward);
        RaycastHit hit;

        //mecanicas del raycasting.
        if (Physics.Raycast(ray, out hit, interactDistance, interactLayer))
        {
            //si presionamos el click izquierdo , actualizará el carryObject y su gravedad.
            if (Input.GetMouseButtonDown(0))
            {
                carryObject = hit.transform;
                carryObject.GetComponent<Rigidbody>().useGravity = false;
                haveObject = true;
            }
        }

        //si presionamos el click izquierdo y tenemos un objeto en la mano, restablecerá el carryObject.
        if (Input.GetMouseButtonUp(0))
        {
            if (haveObject)// se crea una condicion y unas variables tipo bool que usen el componente rigidbody para modificar la gravedad y se pueda alzar el objeto 
            {
                haveObject = false;
                carryObject.GetComponent<Rigidbody>().useGravity = true;
                carryObject = null;
            }
        }

        //Si tenemos un objeto en la mano, actualizamos su posición y lo suavizamos con la interpolación básica
        if (haveObject)
        {
            carryObject.position = Vector3.Lerp(carryObject.position, Camera.main.transform.position + Camera.main.transform.forward * carryDistance, Time.deltaTime * 8);
            carryObject.GetComponent<Rigidbody>().velocity = Vector3.zero;
        }
    }
}