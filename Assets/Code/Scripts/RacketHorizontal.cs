using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RacketHorizontal : MonoBehaviour
{
    public float racketSpeed = 25f;
    //Creo una referencia al eje que quiero utilizar
    public string aye;
    //Esto es una referencia al RigidBody del jugador que nos permite cambiar su velocidad
    public Rigidbody2D rb;

    // Start is called before the first frame update
    void Start()
    {
        //Así inicializaríamos el RigidBody desde código
        //rb = GetComponent<Rigidbody2D>();
    }

    // Ponemos FixedUpdate para que la longitud de cada frame en segundos mida lo mismo, y así el movimiento sea suavizado
    void FixedUpdate()
    {
        //Obtenemos el valor del eje asignado. Que me devuelve 1 si pulso arriba, -1 si pulso abajo, 0 sino pulso
        float HorizontalMovement = Input.GetAxis(aye);
        //Va al componente Rigidbody y le aplicamos una velocidad, que es un Vector2 donde en este caso no lo movemos en X solo en Y
        rb.velocity = new Vector2(HorizontalMovement, 0f ) * racketSpeed; //Multiplicamos por la velocidad de movimiento => 1*25 ó -1*25
    }
}
