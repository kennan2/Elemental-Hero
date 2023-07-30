using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Choose_skill : MonoBehaviour
{
    enum Element { Fire, Water, Cold, Air }
    Element elem = Element.Fire;
    enum Form { Ball, Wall }
    Form form = Form.Ball;

    [SerializeField] Text elemText;
    [SerializeField] Text formText;

    void Start()
    {
        
    }

    
    void Update()
    {
        switch (elem)
        {
            case Element.Fire:
                if (Input.GetKeyDown("e"))
                {
                    elem = Element.Water;
                    elemText.text = "Water";
                    break;
                }
                break;
            case Element.Water:
                if (Input.GetKeyDown("e"))
                {
                    elem = Element.Cold;
                    elemText.text = "Cold";
                    break;
                }
                break;
            case Element.Cold:
                if (Input.GetKeyDown("e"))
                {
                    elem = Element.Air;
                    elemText.text = "Air";
                    break;
                }
                break;
            case Element.Air:
                if (Input.GetKeyDown("e"))
                {
                    elem = Element.Fire;
                    elemText.text = "Fire";
                    break;
                }
                break;
        }
        switch (form)
        {
            case Form.Ball:
                if (Input.GetKeyDown("f"))
                {
                    form = Form.Wall;
                    formText.text = "Wall";
                    break;
                }
                break;
            case Form.Wall:
                if (Input.GetKeyDown("f"))
                {
                    form = Form.Ball;
                    formText.text = "Ball";
                    break;
                }
                break;
        }
    }
    public string CurrentElement()
    {
        return elemText.text;
    }
}
