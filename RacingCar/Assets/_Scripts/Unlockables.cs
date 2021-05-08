using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Unlockables : MonoBehaviour
{
    public GameObject greenButton;
    public int cashValue;

    void Update()
    {
        cashValue = GlobalCoins.TotalCash;
        if(cashValue >= 100){
            greenButton.GetComponent<Button>().interactable = true;
        }
    }

    public void GreenUnlock(){
        greenButton.SetActive(false);
        cashValue -= 100;
        GlobalCoins.TotalCash -= 100;
        PlayerPrefs.SetInt("SavedCash", GlobalCoins.TotalCash);
        PlayerPrefs.SetInt("GreenBought", 100);
    }
}
