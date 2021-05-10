using System.Collections;
using System;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Vehicles.Car;

public class TrackOpponent : MonoBehaviour
{
    public GameObject TheMarker;
    public GameObject Car;
    public GameObject CarControls;
    private Rigidbody m_Rigidbody;
    public GameObject[] Marks;
    public Vector3 LastMark;
    int layer_mask;
    int layer_mask2;
    int index;
    public int MarkTracker;
    float speed;
    Vector3 difference;

    void Start()
    {
        layer_mask = 1 << LayerMask.GetMask("Road");
        m_Rigidbody = Car.GetComponent<Rigidbody>();
        LastMark = Car.transform.position;
        // speed=m_Rigidbody.velocity.magnitude*3.6f;
        Debug.Log(Marks.Length);
    }

    int findIndex(GameObject target, GameObject[] Marks)
    {
        for (int i = 0; i < Marks.Length; i++)
        {
            if (Marks[i].transform.position == target.transform.position)
            {
                return i;
            }
        }
        return -1;
    }

    void FixedUpdate()
    {

        RaycastHit hit;
        // Does the ray intersect any objects excluding the player layer
        if (Physics.Raycast(Car.transform.position, Vector3.down, out hit, 1000, layer_mask))
        {
            if (m_Rigidbody.velocity.magnitude == 0.0f)
            {
                // if (speed == 0 && LastMark != Car.transform.position)
                // {
                //    Debug.Log("AAAAA"); 
                // }
                // Debug.Log(Car.CarControls);
                Debug.Log(LastMark);
                Debug.Log("oi");
            }
            // Debug.DrawRay(transform.position, transform.TransformDirection(Vector3.down) * hit.distance, Color.yellow);
            Debug.Log("Did Hit");

        }
        else
        {
            Car.transform.position = TheMarker.transform.position;
            index = findIndex(TheMarker, Marks);
            if (index != -1)
            {
                if(index == 0){
                    Debug.Log(index);
                    difference = Marks[0].transform.position - Marks[31].transform.position;
                    Quaternion rotation = Quaternion.LookRotation(difference, Vector3.up);
                    Car.transform.rotation = rotation;
                }else{
                    Debug.Log(index);
                    difference = Marks[index].transform.position - Marks[index-1].transform.position;
                    Quaternion rotation = Quaternion.LookRotation(difference, Vector3.up);
                    Car.transform.rotation = rotation;
                }
            }
            
        }
    }
    // Update is called once per frame
    void Update()
    {

        for (int i = 0; i < Marks.Length; i++){
            if(MarkTracker == i)
            { 
                TheMarker.transform.position = Marks[i].transform.position;
            }
        }
        


    }

    IEnumerator OnTriggerEnter(Collider collision){
        if(collision.gameObject.tag=="DreamCar01"){
            this.GetComponent<BoxCollider>().enabled = false;
            MarkTracker +=1;
            if(MarkTracker == 31){
                MarkTracker = 0;
            }
            yield return new WaitForSeconds(1);
            this.GetComponent<BoxCollider>().enabled = true;
        }
    }
}
