using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movimiento : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public float speed = 5f; // Velocidad de movimiento del jugador

    // Método Update se llama una vez por frame
    void Update()
    {
        // Obtener la entrada del teclado para los ejes horizontales y verticales
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

        // Calcular el vector de movimiento
        Vector2 movement = new Vector2(horizontalInput, verticalInput) * speed * Time.deltaTime;

        // Mover el objeto utilizando la física del motor de Unity
        transform.Translate(movement);
    }
}
