using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Carrito : MonoBehaviour {

	private List<int> pesoCarrito;
	private int pesoEnseñar;

	void Start () {
		pesoEnseñar = 0;
		pesoCarrito=new List<int>();
		StartCoroutine(checarCarrito());	
	}

	IEnumerator checarCarrito(){
		while (true) {

			yield return new WaitForSeconds (1);
			pesoCarrito.Clear ();
			pesoEnseñar = 0;
			Collider[] colisiones = Physics.OverlapBox (new Vector3(transform.position.x,transform.position.y+6,transform.position.z), new Vector3(5.5f,4.9f,10.6f));
			for(int i=0;i<colisiones.Length;i++){
				if (colisiones[i].name!="báscula" && colisiones[i].name=="Sphere") {
					//pesoCarrito.Add(colisiones[i].GetComponent<Manzana>().peso);
				}

				else if (colisiones[i].name!="báscula" && colisiones[i].name=="Cube") {
					//pesoCarrito.Add(colisiones[i].GetComponent<Zanahoria>().peso);
				}

				else if (colisiones[i].name!="báscula" && colisiones[i].name=="Cube (1)") {
					//pesoCarrito.Add(colisiones[i].GetComponent<Zanahoria>().peso);
				}

			}
			pesoEnseñar = getPeso ();
			print (pesoEnseñar);
		}
	}

	int getPeso(){
		int pesoTotal = 0;
		for (int i = 0; i < pesoCarrito.Count; i++) {
			pesoTotal += pesoCarrito [i];
		}
		return pesoTotal;
	}
}
