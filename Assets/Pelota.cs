using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SphereMovement : MonoBehaviour
{
    public float speed = 15f; // Velocidad de movimiento
    private Rigidbody rb;

    void Start()
    {
        // Obtenemos el Rigidbody del objeto
        rb = GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
        // Lectura de entradas del teclado
        float moveHorizontal = Input.GetAxis("Horizontal"); // A y D
        float moveVertical = Input.GetAxis("Vertical");     // W y S

        // Vector de movimiento
        Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);

        // Aplicar movimiento al Rigidbody
        rb.AddForce(movement * speed);
    }
}
