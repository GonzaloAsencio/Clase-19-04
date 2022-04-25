using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gatito : MonoBehaviour
{
    [Tooltip("Nombre Del Gatito")]
    public string nombre;


    [Tooltip("Velocidad del Gatito")]
    public float velocidad;

    private void Start()
    {
      //Gracias el return del metodo "SaludoGato" podemos llamarlo para que nos devuelva la frase completa en el Debug.Log
        Debug.Log(SaludoGato(nombre, velocidad));
    }


    //Ejemplo de como usar un  Metodo con retorno(Return)
    public string SaludoGato(string nom,float vel)
    {
        nombre = nom;
        velocidad = vel;
        
        string texto = "Hola, mi nombre es:" + nom + " " + "Tengo una velocidad de :" + " " + vel;

        return texto;

    }
}
