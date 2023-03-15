using DanielLochner.Assets.SimpleScrollSnap;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.UI;

public class Element : MonoBehaviour
{

    public static List<Element> _elements = new List<Element>();


    public bool isSelected = false;
    public int price = 100;
    public GameObject select;
    [SerializeField] private DynamicContent Dc;
    public bool isBuy = false;
    public int ContWhearesInBoard = 60;

    private static int QuantityBuys = 0;

    public List<Element> GetElements() => _elements;

    private void Awake()
    {
        GetComponentInChildren<Text>().text = price.ToString();
        select = GameObject.FindGameObjectWithTag("Selected");

        Dc = GameObject.FindObjectOfType<DynamicContent>();
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

        select.transform.localPosition = Vector3.zero;

        
        Debug.Log("���������� ������� - " + _elements.Count);


        isSelected = true;

        QuantityBuys += 1;


        if (QuantityBuys % ContWhearesInBoard==0)
        {

            Dc.Add(1);
            price += 20;
        
        }

    }



}


