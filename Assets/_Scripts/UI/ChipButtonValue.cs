using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChipButtonValue : MonoBehaviour
{
    public BetValueController bvc;
    public GameObject table;
    BetTracker bt;
    public enum ChipType
    {
        Fifty = 50,
        Hundred = 100,
        TwoFifty = 250,
        FiveHundred = 500
    }
    public ChipType chipType;
    public int currentChipValue, startingChipValue;
    

    private void Start()
    {   

        bt = table.GetComponent<BetTracker>();
        chipType = GetComponent<ChipButtonValue>().chipType;
        
        currentChipValue = GetComponent<ChipButtonValue>().currentChipValue;
        startingChipValue = GetComponent <ChipButtonValue>().startingChipValue;
        //Debug.Log(gameObject.name + " is of chiptype = " + chipType + " and scv of " + startingChipValue);
    }

    public void AddChipValue()
    {
        
        currentChipValue += startingChipValue;
        
    }
    public void SendChipValue()
    {
        bt.currentBetValue = startingChipValue;
    }
}
