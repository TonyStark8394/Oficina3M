using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlocoDeDano : MonoBehaviour
{
    public int dano = 1;  

    
    private void OnCollisionEnter(Collision colisao)
    {
        if (colisao.gameObject.CompareTag("Player"))  
        {
            PlayerHealth playerHealth = colisao.gameObject.GetComponent<PlayerHealth>(); 
            if (playerHealth != null)
            {
                playerHealth.ReceberDano();  
            }
        }
    }
}
