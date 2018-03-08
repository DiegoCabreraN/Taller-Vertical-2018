using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Báscula : MonoBehaviour {

	private List<int> pesoBascula;
	private int pesoEnseñar;

	void Start () {
		pesoEnseñar = 0;
		pesoBascula=new List<int>();
		StartCoroutine(checarBascula());	
	}

	IEnumerator checarBascula(){
		while (true) {
			yield return new WaitForSeconds (.5f);
			pesoBascula.Clear ();
			pesoEnseñar = 0;
			Collider[] colisiones = Physics.OverlapBox (new Vector3(transform.position.x,transform.position.y,transform.position.z), new Vector3(4.7f,1.8f,4.8f));
			for(int i=0;i<colisiones.Length;i++){
				if (colisiones[i].name!="báscula" && colisiones[i].name=="Sphere") {
					//pesoBascula.Add(colisiones[i].GetComponent<Fruta>().peso);
				}

				else if (colisiones[i].name!="báscula" && colisiones[i].name=="Cube") {
					//pesoBascula.Add(colisiones[i].GetComponent<Fruta>().peso);
				}
			}
			pesoEnseñar = getPeso ();
			print (pesoEnseñar);
		}
	}

	int getPeso(){
		int pesoTotal = 0;
		for (int i = 0; i < pesoBascula.Count; i++) {
			pesoTotal += pesoBascula [i];
		}
		return pesoTotal;
	}
}
