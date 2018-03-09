using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Báscula : MonoBehaviour {

	private List<int> pesoBascula;
	private int pesoEnseñar;
    public GameObject text;

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
			Collider[] colisiones = Physics.OverlapBox (new Vector3(transform.position.x,transform.position.y-.1f,transform.position.z), new Vector3(.5f,.18f,.55f));
			for(int i=0;i<colisiones.Length;i++){
				if (colisiones[i].name!="Bascula") {
                    pesoBascula.Add(colisiones[i].GetComponent<Fruta>().peso);
				}

			}
			pesoEnseñar = getPeso ();
            text.GetComponent<Text>().text = pesoEnseñar.ToString() + " gr";
        }
	}

    private void Update()
    {
        StartCoroutine(checarBascula());
    }

    int getPeso(){
		int pesoTotal = 0;
		for (int i = 0; i < pesoBascula.Count; i++) {
			pesoTotal += pesoBascula [i];
		}
		return pesoTotal;
	}
}
