using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Unity.XR.CoreUtils;
using UnityEngine;

public class RotateBall : MonoBehaviour
{
    #region Variables

    public int selectedNumber;
    public string objName;

    [SerializeField]
    private RandomNumberGenerator rng;

    public GameObject rotationAnchor;
    public Vector3 target;
    public GameObject numbersPosParent;

    public bool isRotating;


    [Tooltip("Make sure Speed is greater than decrease")]
    public float currentRotationSpeed = 9, decreaseRotSpeed = 3;
    public float initialRotationSpeed, ballFallInSpeed;


    #endregion

    #region Unity Functions
    private void Start()
    {
        initialRotationSpeed = currentRotationSpeed;
    }
    void FixedUpdate()
    {   
        if (isRotating)
        {   
            RotateAroundAnchor();
        }
        if (currentRotationSpeed <= 0) currentRotationSpeed = 0;
        if (currentRotationSpeed == 0)
        {
            isRotating = false;
        }

    }
    #endregion

    #region Event Functions
    public void OnTriggerEnter(Collider other)
    {   
        
        if (other.gameObject.name == objName)
        {
            currentRotationSpeed -= decreaseRotSpeed;

            if (currentRotationSpeed == 0)
            {

                //Invoke("BallFallIn", 0.5f);
                BallFallIn();

            }

        }
        
        
    }
    #endregion

    
    
    #region Custom Functions   

    public void SetSelectedNumAndName()        //set selected number
    {
        rng.RNG();
        selectedNumber = rng.rnum;
        objName = selectedNumber.ToString();
        //Debug.Log(selectedNumber + "..." + objName);
        
    }

    void RotateAroundAnchor()       // Make the parent object rotate at given speed
    {   
        rotationAnchor.transform.Rotate(new Vector3(0, 0, currentRotationSpeed));         
    }

    void BallFallIn()       // Make the ball fall inside the no. slot       
    {
        target = numbersPosParent.transform.GetChild(selectedNumber).position;
        transform.position = Vector3.MoveTowards(transform.position, target, ballFallInSpeed * Time.fixedDeltaTime);
        if (target == numbersPosParent.transform.GetChild(selectedNumber).position)
        { currentRotationSpeed = 0; }
    }
    #endregion

}
