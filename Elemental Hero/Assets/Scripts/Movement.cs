using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    [SerializeField] float speed = 2; //скорость персонажа
    Rigidbody rb; //ссылка на Rigidbody
    Vector3 direction; //Направление движения
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");
        direction = transform.TransformDirection(x, 0, z);
        if (x > 0)
        {
            GetComponent<Animator>().SetInteger("movement_state", 4);
        }
        else if (x < 0)
        {
            GetComponent<Animator>().SetInteger("movement_state", 2);
        }
        else if (z > 0)
        {
            GetComponent<Animator>().SetInteger("movement_state", 1);
        }
        else if (z < 0)
        {
            GetComponent<Animator>().SetInteger("movement_state", 3);
        }
        else if(x == 0 & z == 0)
        {
            GetComponent<Animator>().SetInteger("movement_state", 0);
        }
    }
    private void FixedUpdate()
    {
        rb.MovePosition(transform.position + direction * speed * Time.fixedDeltaTime);
    }
}
