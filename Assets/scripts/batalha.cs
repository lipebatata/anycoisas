using System;
using UnityEngine;
using UnityEngine.SceneManagement;

public class batalha : MonoBehaviour
{
    public SistemaDeVida sistemaDeVidaAmigo;
    public SistemaDeVida sistemaDeVidaInimigo;
    int vidaInimigo = 100;
    int vidaAmigo = 100;
    int danoInimigo = 10;
    int danoAmigo = 20;
    private AudioSource source;
    public void Atacar()
    {
       vidaInimigo -= danoAmigo;
        sistemaDeVidaInimigo.vida = vidaInimigo;

        if (vidaInimigo < 1)
        {
            Vencer();
        }

        vidaAmigo -= danoInimigo;
        sistemaDeVidaAmigo.vida = vidaAmigo;

        if (vidaAmigo < 1)
        {
            Morrer();
        }

    }

    private void Vencer()
    {
        SceneManager.LoadScene("exploracao", LoadSceneMode.Single);
    }

    void Morrer()
    {
        SceneManager.LoadScene("menu", LoadSceneMode.Single);

    }
    public void Fugir()
    {
        
        SceneManager.LoadScene("exploracao", LoadSceneMode.Single);
    }
}
