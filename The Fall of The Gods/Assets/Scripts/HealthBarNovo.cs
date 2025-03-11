using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBarNovo : MonoBehaviour
{
    public Slider slider;

    public void DefinirVidaMaxima(int vida)
    {
        slider.maxValue = vida;
        slider.value = vida;
    }

    public void DefinirVidaAtual(int vida)
    {
        slider.value = vida;
    }
}

