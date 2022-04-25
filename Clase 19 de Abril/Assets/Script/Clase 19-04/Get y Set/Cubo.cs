using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cubo : MonoBehaviour
{
    [Tooltip ("Velocidad del jugador")]
    public float velocidad;

    [Tooltip("Nombre del jugador")]
    public string nombre;

    public string Nombre { get => nombre; set => nombre = value; }
    
    //otra forma de escribirlo:public string Nombre { get ; set; }

    private void FixedUpdate()
    {
        Movimiento();
    }

    void Movimiento()
    {
        float speed_x = Input.GetAxis("Horizontal");
        transform.position += new Vector3(speed_x, 0, 0) * Time.deltaTime * velocidad;
    }


}
