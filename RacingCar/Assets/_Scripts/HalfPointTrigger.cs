using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HalfPointTrigger : MonoBehaviour
{
    public GameObject LagCompleteTrig;
    public GameObject HalflapTrig;

    void OnTriggerEnter(){
        LagCompleteTrig.SetActive(true);
        HalflapTrig.SetActive(false);
    }
}
