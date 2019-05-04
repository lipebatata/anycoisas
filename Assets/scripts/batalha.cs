using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class batalha : MonoBehaviour
{
    public class Personagem
    {
        int vida = 100;
        int dano = 10;

        void Atacar()
        {
            vida = vida - dano;
            if (vida < 1)
            {
                SceneManager.LoadScene("exploracao", LoadSceneMode.Additive);
            }
        }
    }

}
