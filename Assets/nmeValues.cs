using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class nmeValues : MonoBehaviour
{
    
    public static Vector3 mousePosition;
    public static Camera theCamera;

    // Start is called before the first frame update
    void Start()
    {
        theCamera = Camera.main;
    }

    // Update is called once per frame
    void Update()
    {
        mousePosition = Input.mousePosition;
    }
}
