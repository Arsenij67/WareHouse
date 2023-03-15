using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Money : MonoBehaviour
{
    [SerializeField] private Text collMoney;
    private int money = 2147483647;

    void Update()
    {
        collMoney.text = money.ToString();
    }
}
