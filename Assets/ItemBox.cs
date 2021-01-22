using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemBox : MonoBehaviour
{

    public bool isOveraped = false;


    private Renderer myRenderer;

    public Color touchColor;
    private Color originalColor;
    void Start()
    {
        myRenderer = GetComponent<Renderer>();
        originalColor = myRenderer.material.color;
    }

    void Update()
    {
        
    }

    // OnTriggerEnter는 충돌을 한 그 순간
    void OnTriggerEnter(Collider other)
    {
        if(other.tag == "EndPoint")
        {
            isOveraped = true;
            myRenderer.material.color = touchColor;
        }
    }

    // OnTriggerExit은 붙어있다가 떼어질 때
    void OnTriggerExit(Collider other)
    {
        if(other.tag == "EndPoint")
        {
            isOveraped = false;
            myRenderer.material.color = originalColor;
        }
    } 

    // OnTriggerStay는 충돌하고 있는 혹은 붙어 있는 동안
    void OnTriggerStay(Collider other)
    {
        if(other.tag == "EndPoint")
        {
            isOveraped = true;
            myRenderer.material.color = touchColor;
        }
    }
}
