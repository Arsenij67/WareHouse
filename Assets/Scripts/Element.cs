using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.UI;

public class Element : MonoBehaviour
{

    private static List<Element> _elements = new List<Element>();


    public bool isSelected = false;
    public int price = 100;
    public GameObject select;

    public bool isBuy = false;

    public List<Element> GetElements() => _elements;

    private void Awake()
    {
        GetComponentInChildren<Text>().text = price.ToString();
        select = GameObject.FindGameObjectWithTag("Selected");
    }
    public void Select()
    {
        if (isBuy) return;


        _elements.Clear();
        _elements.AddRange(GameObject.FindObjectsOfType<Element>());

        foreach(var el in _elements)
        {
            el.isSelected = false;
        }

        select.transform.SetParent(this.gameObject.transform);

        select.transform.localPosition = new Vector3(-30, -70, 0);


        Debug.Log("���������� ������� - " + _elements.Count);


        isSelected = true;




    }



}


