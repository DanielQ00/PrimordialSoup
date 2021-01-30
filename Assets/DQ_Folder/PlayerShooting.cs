using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShooting : MonoBehaviour
{
    Vector2 mousePos;
    public Camera cam;

    void Update()
    {
        mousePos = cam.ScreenToWorldPoint(Input.mousePosition);
    }
}
