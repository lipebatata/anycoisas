using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SistemaDeVida : MonoBehaviour
{
    public Slider barraDeVida;
    public float vidaMaxima = 100f;
    public float vida = 0;

    private void Start()
    {
        barraDeVida.minValue = 0;
        barraDeVida.maxValue = vidaMaxima;
        barraDeVida.value = vidaMaxima;
        vida = vidaMaxima;

    }
    private void Update()
    {
        ControleDeVida();
        barraDeVida.value = vida;
    }

    private void ControleDeVida()
    {
        if (barraDeVida.value >= vidaMaxima)
        {
            barraDeVida.value = vidaMaxima;
        }
        if (barraDeVida.value <= barraDeVida.minValue)
        {
            barraDeVida.value = barraDeVida.minValue;
        }
    }
}
