using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUps : MonoBehaviour
{
    /*-----------[Atributos de la clase PowerUps]------------------*/
    [Tooltip("Puntaje al Colisionar")]
    int score;

    [Tooltip("Velocidad de movimiento")]
    int velocidad;



    /*-----------[Metodos de la clase PowerUp]------------------*/
    void Movimiento()
    {
        //Me muevo en distintas direcciones
    }

    void Colision()
    {
        //Al colisionar con el jugador doy "X" poder.
    }
}
