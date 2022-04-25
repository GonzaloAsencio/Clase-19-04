using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CanvasManager : MonoBehaviour
{
    [Tooltip("Referencia del GameObject:Panel del Juego ")]
    public GameObject panel;

    [Tooltip("Referencia Texto dentro del juego")]
    public Text text;

    [Tooltip("Referencia de la Animación del Panel")]
    private Animator anim;

    [Tooltip("Parámetro del texto")]
    private string texto;

    private void Start()
    {
        anim = GetComponent<Animator>();
    }

    //EJEMPLO:Métodos sin parámetros
    public void AbrirCartel()
    {
        anim.Play("PoUp");
    }

    public void CerrarCartel()
    {
        anim.Play("PopOut");
    }

   //EJEMPLO:Métodos con parámetros por valor
    public void IntroducirTexto(string texto)
    {
        //Utilizamos el parametro "texto" para guardarlo en la referencia "text" y asi poder mostrar el texto en la pantalla.
        text.text = texto;
    }


}
