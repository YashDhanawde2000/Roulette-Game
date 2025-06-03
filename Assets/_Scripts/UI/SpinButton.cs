using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SpinButton : MonoBehaviour
{
    public RotateBall RB;
    public RandomNumberGenerator rng;
    public RewardHandler rewardHandler;
    public EnableDisableButtons edb;
    
    
    public GameObject ball;
    
    public Vector3 ballPos;
    public bool isSpinning;

    private void Start()
    {
        ballPos = ball.gameObject.transform.position;
        edb = gameObject.GetComponent<EnableDisableButtons>();
    }
    private void Update()
    {
        
    }

    public void SpinButtonFunctionality()
    {   
        
        ball.gameObject.transform.position = ballPos;
        RB.SetSelectedNumAndName();
        RB.currentRotationSpeed = RB.initialRotationSpeed;
        RB.isRotating = true;             isSpinning = true;
        rewardHandler.ComputeReward();
                
        //edb.AllButtonsEnable();
        //edb.SpinButtonDisable();
        //edb.TableButtonsDisable();
        //gameObject.GetComponent<EnableDisableButtons>().AllButtonsEnable();
        //gameObject.GetComponent<EnableDisableButtons>().SpinButtonDisable();
        //gameObject.GetComponent<EnableDisableButtons>().TableButtonsDisable();
    }
}
