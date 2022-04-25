using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mario : MonoBehaviour
{ /*-----------[Atributos de la clase Mario]------------------*/

    [Tooltip("Vida de Mario")]
    int vida;

    [Tooltip("Velocidad de Mario")]
    float speed;

    [Tooltip("Fuerza de Salto")]
    float Jump;
    
    [Tooltip("Velocidad Maxima")]
    float velmax;


    /*-----------[Metodos de la clase Mario]------------------*/
    void Movimiento()
    {
        //Movimiento del jugador
    }

    void Salto()
    {
        //Estoy Saltando
    }

    void Correr()
    {
        //Estoy Corriendo
    }

    void Muerte()
    {
        //Si mi vida llego a 0 estoy muerto.
    }
}
