using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PlayerHealth : MonoBehaviour
{
        public int vidaMaxima = 2; 
        public int vidaAtual; 
        public int vidasExtras = 2; 
    
        public HealthBarNovo barraDeVida; 
        public TextMeshProUGUI textoVidas; 
        public GameOver telaGameOver; 
    
        void Start()
        {
            vidaAtual = vidaMaxima;
            if (barraDeVida != null) barraDeVida.DefinirVidaMaxima(vidaMaxima);
            AtualizarUI();
        }
    
        void AtualizarUI()
        {
            if (barraDeVida != null) barraDeVida.DefinirVidaAtual(vidaAtual);
            if (textoVidas != null) textoVidas.text = "Vidas Extras: " + vidasExtras;
        }
    
        public void ReceberDano()
        {
            vidaAtual--;
            AtualizarUI();
    
            if (vidaAtual <= 0)
            {
                if (vidasExtras > 0)
                {
                    vidasExtras--;
                    vidaAtual = vidaMaxima; // Restaura a saúde
                }
                else
                {
                    FimDeJogo();
                }
            }
            AtualizarUI();
        }
    
        void FimDeJogo()
        {
            Debug.Log("GAME OVER");
            if (telaGameOver != null) telaGameOver.MostrarTelaGameOver();
        }
}

