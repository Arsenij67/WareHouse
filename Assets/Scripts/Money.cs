using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Money : MonoBehaviour
{
    [SerializeField] private Text countMoney;
    [SerializeField] private Element element;
    private int money = 2147483647;

    void Update()
    {
        countMoney.text = money.ToString();
    }

    public void ChangedCountMoney()
    {
        element = FindObjectOfType<Element>();

        if (money <= 0 || element == null) return;

        var selectElements = element.GetElements(); 

        foreach(var el in selectElements)
        {
            if(el.isSelected && !el.isBuy)
            {
                money -= el.price;
                el.transform.GetChild(1).gameObject.SetActive(false);
                el.transform.GetChild(2).gameObject.SetActive(false);
                el.isBuy = true;
               
            }
        }
    }
}
