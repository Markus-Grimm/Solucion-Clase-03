using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class Ejercicio4 : MonoBehaviour
{
    /*---- Busca otra alternativa ----*/

    /*Dato:Queremos saber si existe el nombre de un enemigo dentro de una lista.
      Podriamos mejorarlo usando algun metodo de Linq.
    */

    public List<string> enemies = new List<string>() { "Orc", "Spider", "Golem", "Goblin" };
    string enemy = "Spider";

    void Start()
    {
        EncontrandoEnemigo();
    }

    string EncontrandoEnemigo()
    {
        IEnumerable<string> myEnumerable = enemies.Where(x => x == enemy);
        
        foreach (string name in myEnumerable)
        {
            if (name == enemy)
            {
                return "Se Encontro";
            }                        
        }

        return "No se encontro";
    }
}