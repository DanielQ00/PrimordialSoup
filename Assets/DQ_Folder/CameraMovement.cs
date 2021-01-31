using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    GameObject mainCam;
    public GameObject newLocation;

    private void Start()
    {
        mainCam = FindObjectOfType<Camera>().gameObject;
    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.GetComponent<PlayerMovement>())
        {
            mainCam.transform.position = newLocation.transform.position;
        }
    }
}
