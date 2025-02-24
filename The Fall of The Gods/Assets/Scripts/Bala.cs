using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bala : MonoBehaviour
{
 [SerializeField] float speed;  
    [SerializeField] float tempodeVida;  
    public float chargeTime = 0;  // Tempo de carga da bala (passado pela classe SistemadeArma)
    public float totalChargeTime = 2;  // Tempo necessário para carregar totalmente a bala
    private float scaleMultiplier = 1f;  // Multiplicador de escala da bala
    void Start()
    {
        Destroy(gameObject, tempodeVida);  // A bala será destruída após o tempo de vida
    }

    void Update()
    {
        // Calculando o multiplicador de escala com base no tempo de carga
        scaleMultiplier = Mathf.Lerp(1f, 2f, chargeTime / totalChargeTime); // Você pode ajustar o tamanho que vai se multiplicar no "2f".

        // Aplicando a escala da bala
        transform.localScale = new Vector3(scaleMultiplier, scaleMultiplier, 1f);

        // Movimentação da bala
        transform.Translate(Vector2.right * speed * Time.deltaTime);
    }
}
