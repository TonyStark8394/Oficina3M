using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ataquePlayer : MonoBehaviour
{
 private bool atacando;
    public Transform ataquePoint;

    public float ataqueRanger = 0.5f;
    public LayerMask enemysLayers;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        atacando = Input.GetButtonDown("Fire1");

        if(atacando == true){
            Ataque();
        }
    }
    void Ataque(){
        // vai ser o range de ataque de acertar o nosso inimigo;
        Collider2D[] hitEnemies = Physics2D.OverlapCircleAll(ataquePoint.position, ataqueRanger, enemysLayers);
        
        // dano no inimigo (é necessário o inimigo);
    }
}
