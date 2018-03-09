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
    public Carrito carrito;
    public bool respuestaCorrecta;
    public bool checkEnd;

	void Start () {
		porCobrar = 0;
		totalMonedero = 100;
		cosasEnCarrito = false;
        checkEnd = false;
    }

    void Update()
    {
    }

    public void calculateTotalResults()
    {
        StartCoroutine(carrito.checarCarrito());
    }
	
    public bool getResult()
    {
        return respuestaCorrecta;
    }

    public void updateRespuestaCorrecta(bool result)
    {
        respuestaCorrecta = result;
        checkEnd = true;
    }
}
