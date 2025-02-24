using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
        public float velocity;
    void Start()
    {
        
    }

    void Update()
    {
        
    }
    void FixedUpdate()
    {
        Move();
    }
    void Move()
        {
            Vector3 move = new Vector3(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"), 0f);
            transform.position += move * Time.deltaTime * velocity;
            if (Input.GetAxis("Horizontal") > 0f)
            {
                transform.eulerAngles = new Vector3(0f, 0f, 0f);
                Debug.Log("Correndo para direita");
            }
            if (Input.GetAxis("Horizontal") < 0f)
            {
                transform.eulerAngles = new Vector3(0f, 180f, 0f);
                Debug.Log("Correndo para eesquerda");
            }
            if (Input.GetAxis("Horizontal") == 0f)
            {
                Debug.Log("Parado");
            }
        }
}
