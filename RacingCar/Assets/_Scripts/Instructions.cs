using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Instructions : MonoBehaviour
{
    public GameObject InstructionsStart;

    public float time = 5; //Seconds to read the text

    IEnumerator Start ()
    {
        yield return new WaitForSeconds(time);
        InstructionsStart.SetActive(false);
    }
}
