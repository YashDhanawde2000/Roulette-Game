using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateWheel : MonoBehaviour
{
    
    public RotateBall rbScript;

    public float rSpeed;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (rbScript.isRotating) 
        {
            transform.Rotate(new Vector3(0, 0, rSpeed));
        }
        else
        {
            transform.Rotate(new Vector3(0, 0, 0));
        }
        
    }
}
