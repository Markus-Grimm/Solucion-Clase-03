using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio3 : MonoBehaviour
{
    /*---- Ordena el Codgo  ----*/

    private float _Speed;
    private float _Speed2;
    public float Z;
    public float movement_x;


    bool isJumping;
    
    private Rigidbody2D physics;

    private void Start()
    {
        physics = GetComponent<Rigidbody2D>();
        movement_x = Input.GetAxis("Horizontal");
    }
    private void Update()
    {
        Movement();
    }

    public void Movement()
    {
        //Movimiento del jugador - Der
        if (Input.GetKeyDown(KeyCode.D))
        {
            physics.velocity = new Vector2(movement_x * _Speed, 0);
        }
        //Movimiento del jugador - Izquierda
        if (Input.GetKeyDown(KeyCode.A))
        {
            physics.velocity = new Vector2(movement_x * _Speed, 0);
        }

        //Rotacion del jugador
        if (Input.GetKeyDown(KeyCode.R))
        {
            Z += Time.deltaTime * 10;
            transform.rotation = Quaternion.Euler(0, 0, Z);
        }

        //Salto del jugador 
        if (Input.GetButton("Jump") && !isJumping)
        {
            //Le aplico la fuerza de salto
            physics.AddForce(Vector2.up * _Speed2);
            Debug.Log("Estoy saltando Wiiii");
            //Digo que esta saltando (para que no pueda volver a saltar)
            isJumping = true;
        }
    }

    //....
}