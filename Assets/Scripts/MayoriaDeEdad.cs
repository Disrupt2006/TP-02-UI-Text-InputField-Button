﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MayoriaDeEdad : MonoBehaviour {

    public int edadUsuario;
    public Text miTexto;

	// Use this for initialization
	void Start ()
    {
        if (edadUsuario >= 18)
        {
            miTexto.text = "Es mayor de edad";
            Debug.Log("Es mayor de edad");
        }

        else
        {
            miTexto.text = "No es mayor de edad";
            Debug.Log("No es mayor de edad");
        }
           
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
