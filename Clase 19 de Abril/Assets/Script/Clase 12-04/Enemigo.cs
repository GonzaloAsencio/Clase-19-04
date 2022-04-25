using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemigo : MonoBehaviour
{
    /*-----------[Atributos de la clase Enemigo]------------------*/

    [Tooltip ("Vida del Enemigo")]
    int vida;

    [Tooltip("Velocidad del Enemigo")]
    float speed;

    [Tooltip("Puntaje al Morir")]
    int score;


    /*-----------[Metodos de la clase Enemigo]------------------*/
    void Movimiento()
    {
        //Camino hacia los Laterales
    }

    void Muerte()
    {
      //Si mi vida llego a 0 estoy muerto.
    }
}
