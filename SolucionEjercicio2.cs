using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio02 : MonoBehaviour
{
    /*---- Mejora el codigo  ----*/

    //Dato:no se que es,pero siento que algo no esta bien.


    private int fuerza;
    private int agilidad;
    private int fueMin;
    private int agiMin;

    private void Start()
    {
        fuerza = 100;
        agilidad = 50;

        fueMin = 0;
        agiMin = 40;
    }

    private void Update()
    {

    }

    private void EjecutarAtaqueEspecial()
    {
        if ((fuerza >= fueMin) && (agilidad > agiMin))
        {
            Debug.Log("Ataque especial ejecutado");
        }
    }
}