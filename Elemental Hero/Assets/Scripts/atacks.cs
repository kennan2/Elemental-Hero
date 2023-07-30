using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class atacks : MonoBehaviour
{
    [SerializeField]GameObject ball;
    [SerializeField] GameObject start;
    [SerializeField] GameObject rot;
    float time;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (time > 2)
        {
            GameObject projectile = Instantiate(ball);
            projectile.GetComponent<Renderer>().material.color = Color.red;
            projectile.GetComponent<projectile>().setDirection(transform.forward);
            projectile.transform.position = start.transform.position;
            projectile.transform.rotation = rot.transform.rotation;
            time = 0;
        }
        else if (time>0)
        {
            time += Time.deltaTime;
        }
        else if (Input.GetMouseButtonDown(0))
        {
            time = Time.deltaTime;
            GetComponent<Animator>().SetBool("atack", true);
            //GameObject projectile = Instantiate(ball);
            //projectile.GetComponent<Renderer>().material.color = Color.red;
            //projectile.GetComponent<projectile>().setDirection(transform.forward);
            //projectile.transform.position = start.transform.position;
            //projectile.transform.rotation = rot.transform.rotation;
        }
        else
        {
            GetComponent<Animator>().SetBool("atack", false);
        }
    }
}
