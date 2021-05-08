using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GreenScore : MonoBehaviour
{
    void OnTriggerEnter(){
        ModeScore.CurrentScore += 25;
        gameObject.SetActive(false);
    }
}
