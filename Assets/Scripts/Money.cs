using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Money : MonoBehaviour
{
    [SerializeField] private Text countMoney;
    private int money = 2147483647;

    void Update()
    {
        countMoney.text = money.ToString();
    }

    public void ChangedCountMoney()
    {
        if (money <= 0) return;

    }
}
