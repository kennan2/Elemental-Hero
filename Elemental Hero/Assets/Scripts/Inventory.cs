using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    [SerializeField] GameObject skill_controller;
    private Choose_skill script; 
    void Start()
    {
        script = skill_controller.GetComponent<Choose_skill>();
        print(script.CurrentElement());
    }

    
    void Update()
    {
        
    }
}
