using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class Element : MonoBehaviour
{

    private static List<Element> _elements = new List<Element>();


    public bool isSelected = false;

    public GameObject select;


    private void Awake()
    {
        select = GameObject.FindGameObjectWithTag("Selected");
    }
    public void Select()
    {



        _elements.Clear();
        _elements.AddRange(GameObject.FindObjectsOfType<Element>());



        select.transform.SetParent(this.gameObject.transform);

        select.transform.localPosition = new Vector3(-30, -70, 0);


        Debug.Log("количество товаров - " + _elements.Count);


        //isSelected = true;




    }



}


