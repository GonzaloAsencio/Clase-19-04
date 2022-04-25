using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TiendaDeArmas : MonoBehaviour
{
    public class Tienda
    {
        public string Nombre
        { get; set; }

        public float Precio
        { get; set; }
    }


    private void Start()
    {
        Tienda Espada = new Tienda { Nombre = "Espada de Hierro", Precio = 1.5f};
        Debug.Log($"{Espada.Nombre}: se vende por {Espada.Precio:C2}");

        Tienda Escudo = new Tienda { Nombre = "Escudo de Madera", Precio = 0.5f };
        Debug.Log($"{Escudo.Nombre}: se vende por {Escudo.Precio:C2}");

        Tienda PistolaLaser = new Tienda { Nombre = "Pistola:Pew-Pew", Precio = 9999f };
        Debug.Log($"{PistolaLaser.Nombre}: se vende por {PistolaLaser.Precio:C2}");

    }

   
       
}
