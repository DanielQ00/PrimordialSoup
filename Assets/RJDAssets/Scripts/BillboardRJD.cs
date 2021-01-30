using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BillboardRJD : MonoBehaviour
{
    public Transform cam;

    // Start is called before the first frame update
    

    // Update is called once per frame
    void LateUpdate()

    {
        transform.LookAt(transform.position + cam.forward);
    }
}
