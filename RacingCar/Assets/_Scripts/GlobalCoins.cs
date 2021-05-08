using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GlobalCoins : MonoBehaviour
{
    public int CashValue;
    public static int TotalCash;
    public GameObject CashDisplay;

    void Start()
    {
        TotalCash = PlayerPrefs.GetInt("SavedCash");
    }

    void Update()
    {
        CashValue = TotalCash;
        CashDisplay.GetComponent<Text>().text = "COINS:" + CashValue;
    }
}
