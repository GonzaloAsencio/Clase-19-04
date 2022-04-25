using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Circulo : MonoBehaviour
{
    [Tooltip("Referencia del Script:CanvasManager")]
    public CanvasManager cm;

    [Tooltip("Referencia de la Animacion del Panel")]
    private Animator anim;


    private void Start()
    {
        anim = GetComponent<Animator>();
    }


    //Metodo de colision
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.GetComponent<Cubo>())
        {
            //Utilizamos el Get de la variable "Nombre" dento de la clase "Cubo" para poder hacer la comparación.
            if (collision.GetComponent<Cubo>().Nombre == "Cubito")
            {
                collision.GetComponent<Cubo>().Nombre = "Circulo"; //Utilizamos el Set de la variable "Nombre" dento de la clase "Cubo" para modificiar su valor.
                string saludo = "No me gusta tu nombre, ahora te llamas" + " " +  collision.GetComponent<Cubo>().Nombre;
                cm.IntroducirTexto(saludo);
                anim.Play("SaludoC");
                cm.AbrirCartel();
            } else
            {
                string saludo = "Me gusta tu nombre";
                cm.IntroducirTexto(saludo);
                cm.AbrirCartel();
                anim.Play("SaludoC_Bueno");
            }
           

        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        cm.CerrarCartel();
    }
}
