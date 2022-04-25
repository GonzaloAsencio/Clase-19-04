using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rectangulo : MonoBehaviour
{
    [Tooltip("Referencia del Script:CanvasManager")]
    public CanvasManager cm;

    [Tooltip("Referencia de la Animacion del Rectangulo")]
    private Animator anim;

    private void Start()
    {
        anim = GetComponent<Animator>();
    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.GetComponent<Cubo>())
        {
            anim.Play("Saludo");
            //Utilizamos el Get de la variable "Nombre" dentro de "Cubo" para poder realizar el saludo.
            string saludo = ("Hola: " + "" + collision.GetComponent<Cubo>().Nombre);
            cm.IntroducirTexto(saludo);
            cm.AbrirCartel();
          
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        cm.CerrarCartel();
    }
  
}
