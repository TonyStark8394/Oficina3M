using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SistemadeArma : MonoBehaviour
{
    Vector2 mousePosi;
    [SerializeField] SpriteRenderer srGun;
    [SerializeField] float tempoEntreTiros;
    bool podeAtiraR = true;
    [SerializeField] Transform pontodeFogo;
    [SerializeField] GameObject tiro;

    private float chargeTime = 0f;  

    void Update()
    {
        // Posição do mouse
        mousePosi = Camera.main.ScreenToWorldPoint(Input.mousePosition);

        if (Input.GetButton("Fire1"))
        {
            chargeTime += Time.deltaTime;  // Aumenta o tempo de carga
        }

        // Disparo do tiro
        if (Input.GetButtonDown("Fire1") && podeAtiraR)
        {
            podeAtiraR = false;

            
            GameObject novoTiro = Instantiate(tiro, pontodeFogo.position, pontodeFogo.rotation);
            
            // Calculando a direção do tiro com base na posição do mouse
            Vector2 direction = (mousePosi - new Vector2(transform.position.x, transform.position.y)).normalized;

            Rigidbody2D rb = novoTiro.GetComponent<Rigidbody2D>();
            if (rb != null)
            {
                rb.velocity = direction * 10f; 
            }
            Bala bala = novoTiro.GetComponent<Bala>();
            if (bala != null)
            {
                bala.chargeTime = chargeTime;
            }
            Invoke("CDTIRO", tempoEntreTiros);

            // Resetando o tempo de carregamento após o disparo
            chargeTime = 0f;
        }
    }

    void CDTIRO()
    {
        podeAtiraR = true;
    }
}
