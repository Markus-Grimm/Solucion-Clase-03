using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SolucionEjercicio5 : MonoBehaviour
{
    /*---- Mejora el Switch ----*/

    //Dato: como podriamos hacer para no usar tantos "if"?

    
    string action = "Attack";
    int hability = 1;


    void ActionRun()
    {
        switch (hability)
        {
            case 1:
                if (action == "Heal")
                    Debug.Log("Me curo");
                break;
            case 2:
                if (action == "Attack")
                    Debug.Log("Hago danio");
                break;
            case 3:
                if (action == "Special Attack")
                    Debug.Log("Empiezo a girar como trompo");
                break;
        }

    }
}
