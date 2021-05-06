using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LoadLapTime : MonoBehaviour
{
    public int MinuteCount;
    public int SecondCount;
    public float MiliCount;

    public GameObject MinDisplay;
    public GameObject SecDisplay;
    public GameObject MiliDisplay;

    void Start()
    {
        MinuteCount = PlayerPrefs.GetInt("MinSave");
        SecondCount = PlayerPrefs.GetInt("SecSave");
        MiliCount = PlayerPrefs.GetFloat("MiliSave");

        if(SecondCount <= 9){
            SecDisplay.GetComponent<Text>().text = "0" + SecondCount + ".";
        }
        else{
            SecDisplay.GetComponent<Text>().text = "" + SecondCount + ".";
        }

        if(LapTimeManagment.MinuteCount <= 9){
            MinDisplay.GetComponent<Text>().text = "0" + MinuteCount + ":";
        }
        else{
            MinDisplay.GetComponent<Text>().text = "" + MinuteCount + ":";
        }
        MiliDisplay.GetComponent<Text>().text = "" + MiliCount;
    }

}
