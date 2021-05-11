using System.Collections;
using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityStandardAssets.Vehicles.Car;

public class CarControlPosition : MonoBehaviour
{
    public Vector3 LastMark;
    public GameObject Car;
    public Quaternion originalRotationValue;
    int layer_mask;
    int layer_mask2;
    public GameObject InstructionsLeftTrack;
    float rotationResetSpeed = 1.0f;
    public GameObject positionDisplay;


    Vector3 difference;

    void Start()
    {
        layer_mask = 1 << LayerMask.GetMask("Road");
        LastMark = Car.transform.position;
        originalRotationValue = Car.transform.rotation;
    }

    void FixedUpdate()
    {

        RaycastHit hit;
        // Does the ray intersect any objects excluding the player layer
        if (Physics.Raycast(Car.transform.position, Vector3.down, out hit, 1000, layer_mask))
        {
            Debug.Log("Did Hit");            
        }
        else
        {
            Debug.Log("Did not Hit");
            InstructionsLeftTrack.GetComponent<Text>().text = "PRESS SPACE TO GO BACK TO THE TRACK";
            InstructionsLeftTrack.SetActive(true);
        }
    }

    void Update()
    {
        if (Input.GetButtonDown("Jump")) 
        {
            Car.transform.position = LastMark + new Vector3(-15, 0, 0);
            Car.transform.rotation = Quaternion.Slerp(Car.transform.rotation, originalRotationValue, Time.time * rotationResetSpeed);
            InstructionsLeftTrack.SetActive(false);
            positionDisplay.GetComponent<Text>().text = "2nd Place";
        }
    }
}
