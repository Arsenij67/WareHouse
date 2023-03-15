using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class Element : MonoBehaviour
{

    private static List<Element> _elements = new List<Element>();

    public bool isSelected = false;
    public void Select()
    {
        


        if(_elements.Count < 1)
        _elements.AddRange(GameObject.FindObjectsOfType<Element>());


        Debug.Log("количество товаров - " + _elements.Count);

        GameObject Childelement = gameObject.transform.GetChild(0).gameObject;

    
    


        foreach (var elem in _elements)
        {


             elem.isSelected = false;
            if(elem.gameObject.transform.childCount > 0)
             elem.gameObject.transform?.GetChild(0)?.gameObject.SetActive(false);
        
        
        }

        Childelement.SetActive(true);
        isSelected = true;




    }



}


