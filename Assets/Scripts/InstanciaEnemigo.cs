using System.Collections;
using System.Collections.Generic;
using UnityEngine;
// este script sirve para instanciar enemigos al ser destruido 
public class InstanciaEnemigo : MonoBehaviour {

	public GameObject  enemy;// un objeto vacio donde va a ir guardado el prefab 
	
	void OnCollisionEnter(Collision otherObj) {// si colisiona y destruye el objeto hace un llamado a la funcion start 
    if (otherObj.gameObject.tag == "Enemy")// se crea una etiqueta como referencia del objeto que sera destruido y clonado 
	{
		Destroy(gameObject,.5f);// espera 5 segundos despues de ser destruido para llamar la funcion start
		Start();
	}
	}
	
	void Start ()// se realiza en start ya que sera ejecutado una vez cada que sea realizada la funcion de la colision 
	{
		 for (int i = 0; i < 5; i++) {// se crea un loop o bucle for 
        Instantiate(enemy);// instancia prefabs
	}
	}
}
	


