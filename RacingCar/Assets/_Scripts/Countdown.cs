using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Countdown : MonoBehaviour
{
    public GameObject CountDown;
    public AudioSource GetReady;
    public AudioSource GoAudio;
    public GameObject LapTimer;
    public GameObject CarControls;
    public GameObject InstructionsStart;
    public GameObject InstructionsCamera;
    public AudioSource LevelMusic;

    void Start()
    {
        StartCoroutine(CountStart());
        if(ModeSelect.RaceMode == 0){
            InstructionsStart.GetComponent<Text>().text = "USE THE ARROWS TO WIN THE RACE";
            InstructionsCamera.GetComponent<Text>().text = "PRESS C TO CHANGE VIEW MODE";
            InstructionsStart.SetActive(true);
            InstructionsCamera.SetActive(true);
        }
        if(ModeSelect.RaceMode == 1){
            InstructionsStart.GetComponent<Text>().text = "COLLECT THE CUBES TO WIN POINTS";
            InstructionsCamera.GetComponent<Text>().text = "PRESS C TO CHANGE VIEW MODE";
            InstructionsStart.SetActive(true);
            InstructionsCamera.SetActive(true);
        }
        if(ModeSelect.RaceMode == 2){
            InstructionsStart.GetComponent<Text>().text = "TRY TO RACE AS FAST AS YOU CAN";
            InstructionsCamera.GetComponent<Text>().text = "PRESS C TO CHANGE VIEW MODE";
            InstructionsStart.SetActive(true);
            InstructionsCamera.SetActive(true);
        }
    }

    IEnumerator CountStart(){
        yield return new WaitForSeconds(0.5f);
        CountDown.GetComponent<Text>().text = "3";
        GetReady.Play();
        CountDown.SetActive(true);
        yield return new WaitForSeconds(1);
        CountDown.SetActive(false);
        CountDown.GetComponent<Text>().text = "2";
        GetReady.Play();
        CountDown.SetActive(true);
        yield return new WaitForSeconds(1);
        CountDown.SetActive(false);
        CountDown.GetComponent<Text>().text = "1";
        GetReady.Play();
        CountDown.SetActive(true);
        yield return new WaitForSeconds(1);
        CountDown.SetActive(false);
        GoAudio.Play();
        LevelMusic.Play();
        LapTimer.SetActive(true);
        CarControls.SetActive(true);

    }

}
