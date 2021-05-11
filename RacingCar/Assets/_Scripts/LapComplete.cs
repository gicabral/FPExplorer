using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LapComplete : MonoBehaviour
{
    public GameObject LapCompleteTrig;
    public GameObject HalflapTrig;
    public GameObject LapTimeManager;

    public GameObject MinuteDisplay;
    public GameObject SecondDisplay;
    public GameObject MiliDisplay;

    public GameObject LapTimeBox;

    public GameObject LapCounter;
    public int LapsDone;

    public float RawTime;

    public GameObject RaceFinish;

    public void OnTriggerEnter(){
        LapsDone += 1;
        RawTime = PlayerPrefs.GetFloat("RawTime");

        if(LapTimeManagment.RawTime <= RawTime){
            if(LapTimeManagment.SecondCount <= 9){
                SecondDisplay.GetComponent<Text>().text = "0" + LapTimeManagment.SecondCount + ".";
            }
            else{
                SecondDisplay.GetComponent<Text>().text = "" + LapTimeManagment.SecondCount + ".";
            }

            if(LapTimeManagment.MinuteCount <= 9){
                MinuteDisplay.GetComponent<Text>().text = "0" + LapTimeManagment.MinuteCount + ":";
            }
            else{
                MinuteDisplay.GetComponent<Text>().text = "" + LapTimeManagment.MinuteCount + ":";
            }

            MiliDisplay.GetComponent<Text>().text = "" + LapTimeManagment.MiliCount;
        }

        PlayerPrefs.SetInt("MinSave", LapTimeManagment.MinuteCount);
        PlayerPrefs.SetInt("SecSave", LapTimeManagment.SecondCount);
        PlayerPrefs.SetFloat("MiliSave", LapTimeManagment.MinuteCount);
        PlayerPrefs.SetFloat("RawTime", LapTimeManagment.RawTime);

        
        LapTimeManagment.MiliCount = 0;
        LapTimeManagment.SecondCount = 0;
        LapTimeManagment.MinuteCount = 0;
        LapTimeManagment.RawTime = 0;
        LapCounter.GetComponent<Text>().text = "" + LapsDone;

        HalflapTrig.SetActive(true);
        LapCompleteTrig.SetActive(false);

        if(LapsDone == 2){
            Debug.Log("Completou");
            RaceFinish.SetActive(true);
        }
    }

    public void Update(){
        // if(LapsDone == 1){
        //     RaceFinish.SetActive(true);
        //     LapTimeManager.SetActive(false);
        // }
    }
}
