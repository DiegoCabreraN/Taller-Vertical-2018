using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Carrito : MonoBehaviour {
    // pasarle el pulpp
	private List<int> preciosCarrito;
	private int precioEnseñar;
	public GameObject cobrador;

	void Start () {
		precioEnseñar = 0;
		preciosCarrito=new List<int>();
	}

	public IEnumerator checarCarrito(){
		while (true) {
			yield return new WaitForSeconds (1);
			preciosCarrito.Clear ();
			precioEnseñar = 0;
            print("as");
			Collider[] colisiones = Physics.OverlapBox (new Vector3(transform.position.x+.5f,transform.position.y,transform.position.z), new Vector3(1.04f,.5f,.48f));
            /*for (int i=0;i<colisiones.Length;i++){

				if (colisiones[i].name!="Carrito") {
					preciosCarrito.Add(colisiones [i].GetComponent<Fruta> ().precio);
				}
			}*/

			cobrador.GetComponent<Cobrador> ().porCobrar = getPrecio ();
			cobrador.GetComponent<Cobrador> ().updateRespuestaCorrecta(listaCompleta(colisiones));
		}
	}

	int getPrecio(){
		int precioTotal = 0;
		for (int i = 0; i < preciosCarrito.Count; i++) {
			precioTotal += preciosCarrito [i];
		}
		return precioTotal;
	}

	bool listaCompleta(Collider[] colisiones){
		//1 lata atun
		//1 kg manzana
		//2.5 kg zanahoria
		//3 yogurth
		float manzana=0;
		float zanahoria = 0;
		int yogurth = 0;
		int lataAtun = 0;

		bool otrasCosas=false;


		for (int i = 0; i < colisiones.Length; i++) {
			if(colisiones[i].name=="Manzana"){
				manzana += colisiones [i].GetComponent<Fruta> ().peso;
			}
			else if(colisiones[i].name=="Zanahoria"){
				manzana += colisiones [i].GetComponent<Fruta> ().peso;

			}
			else if(colisiones[i].name=="Atun"){
				lataAtun += 1;
			}
			else if(colisiones[i].name=="Yogurth"){
				yogurth += 1;
			}
			else{
				otrasCosas=true;
			}
		}

		return(manzana == 1 && zanahoria == 2.5 && lataAtun == 1 && yogurth == 3 && !otrasCosas);
			
	}
}
