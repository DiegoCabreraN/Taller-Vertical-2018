using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cobrador : MonoBehaviour {

	// Use this for initialization

	//se definen en la clase
	public float porCobrar;
	public bool cosasEnCarrito;
	private int totalMonedero;
    public GameObject boton;

	void Start () {
		porCobrar = 0;
		totalMonedero = 100;
		cosasEnCarrito = false;
	}

    void Update()
    {
        if (cosasEnCarrito)
        {
            boton.GetComponent<ButtonController>().cobrar = true;
        }

    }
	


}
