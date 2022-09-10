using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class SolucionEjercicio1 : MonoBehaviour
{    
    public float fuerza;

    private Rigidbody2D rb_2d;

    public float speed;

    private void Start()
    {
        fuerza = 100f;
        speed = 10f;
        rb_2d = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        //Movimiento del jugador
        float x = Input.GetAxis("Horizontal");
        float y = Input.GetAxis("Vertical");

        rb_2d.velocity = new Vector2(x * speed, y * fuerza);

    }
}