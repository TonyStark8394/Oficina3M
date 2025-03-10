using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bala : MonoBehaviour
{
 [SerializeField] float speed;  
    [SerializeField] float tempodeVida;  
    public float chargeTime = 0;  
    public float totalChargeTime = 2;  
    private float scaleMultiplier = 1f;  
    void Start()
    {
        Destroy(gameObject, tempodeVida);  // A bala será destruída após o tempo de vida
    }

    void Update()
    {
        scaleMultiplier = Mathf.Lerp(1f, 2f, chargeTime / totalChargeTime); // Você pode ajustar o tamanho que vai se multiplicar no "2f".

        transform.localScale = new Vector3(scaleMultiplier, scaleMultiplier, 1f);

        // Movimentação da bala
        transform.Translate(Vector2.right * speed * Time.deltaTime);
    }
}
