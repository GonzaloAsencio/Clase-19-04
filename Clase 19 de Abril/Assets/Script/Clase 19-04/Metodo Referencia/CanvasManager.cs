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

    [Tooltip("Referencia de la Animaci�n del Panel")]
    private Animator anim;

    [Tooltip("Par�metro del texto")]
    private string texto;

    private void Start()
    {
        anim = GetComponent<Animator>();
    }

    //EJEMPLO:M�todos sin par�metros
    public void AbrirCartel()
    {
        anim.Play("PoUp");
    }

    public void CerrarCartel()
    {
        anim.Play("PopOut");
    }

   //EJEMPLO:M�todos con par�metros por valor
    public void IntroducirTexto(string texto)
    {
        //Utilizamos el parametro "texto" para guardarlo en la referencia "text" y asi poder mostrar el texto en la pantalla.
        text.text = texto;
    }


}
