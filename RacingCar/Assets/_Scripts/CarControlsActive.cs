using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Vehicles.Car;

public class CarControlsActive : MonoBehaviour
{
    public GameObject CarControl;
    public GameObject OpponentCar;
    public static bool check;

    // Start is called before the first frame update
    void Start()
    {
        CarControl.GetComponent<CarController>().enabled = true;
        CarControl.GetComponent<CarUserControl>().enabled = true;
        check = true;
        OpponentCar.GetComponent<CarAIControl>().enabled = true;
    }
}

