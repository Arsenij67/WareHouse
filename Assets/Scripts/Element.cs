using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Element : MonoBehaviour
{

    private static List<Element> _elements = new List<Element>();

    public bool isSelected = false;
    public void Select()
    {
        print("dcbsd");
        _elements.AddRange(FindObjectsOfType<Element>());

        print("количество товаров - " + _elements.Count);

        GameObject element = gameObject.transform.GetChild(0).gameObject;

        element.SetActive(true);

        isSelected = true;
    
    
    
    }


    
}


