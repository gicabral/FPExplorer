﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PosUp : MonoBehaviour
{
    public GameObject positionDisplay;

    void OnTriggerEnter(Collider other){
        if(other.tag == "CarPos"){
            positionDisplay.GetComponent<Text>().text = "1st Place";
        }
    }
}
