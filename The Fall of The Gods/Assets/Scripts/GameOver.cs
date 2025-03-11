using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class GameOver : MonoBehaviour
{
    public GameObject painelGameOver;
    public TextMeshProUGUI textoGameOver;

    void Start()
    {
        textoGameOver.gameObject.SetActive(false);
    }

    public void MostrarTelaGameOver()
    {
        painelGameOver.SetActive(true);
        textoGameOver.gameObject.SetActive(true);
    }

    public void ReiniciarJogo()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void SairDoJogo()
    {
        Application.Quit();
    }
}