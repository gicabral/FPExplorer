using System.Collections;
using System;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Vehicles.Car;

public class CarControlPosition : MonoBehaviour
{
    public Vector3 LastMark;
    public GameObject Car;
    int layer_mask;
    int layer_mask2;

    Vector3 difference;

    void Start()
    {
        layer_mask = 1 << LayerMask.GetMask("Road");
        LastMark = Car.transform.position;
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
        }
    }

    void Update()
    {
        if (Input.GetButtonDown("Jump")) 
        {
            Car.transform.position = LastMark;
        }
    }
}
