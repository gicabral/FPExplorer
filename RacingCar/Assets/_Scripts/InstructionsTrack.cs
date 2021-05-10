using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InstructionsTrack : MonoBehaviour
{
    public GameObject InstructionsLeftTrack;
    public float time = 5; //Seconds to read the text

    IEnumerator Start ()
    {
        yield return new WaitForSeconds(time);
    }

    // void FixedUpdate(){
    //     InstructionsLeftTrack.SetActive(false);
    // }

}
