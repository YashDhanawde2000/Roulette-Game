using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Bet : MonoBehaviour
{
    public GameObject table, buttonPressedObject;
    public int amtMultiplier;
    public bool outsideBet;
    BetTracker bt;


    private void Start()
    {   
        buttonPressedObject = gameObject;
        outsideBet = gameObject.GetComponent<Bet>().outsideBet;
        gameObject.GetComponent<Button>().onClick.AddListener(SendTableValues);
        amtMultiplier = gameObject.GetComponent<Bet>().amtMultiplier;
        bt = table.GetComponent<BetTracker>();
    }

    public void SendTableValues()
    {
        bt.clickedButton = buttonPressedObject;
        bt.currentBetMultiplier = amtMultiplier;
        bt.PlaceBet();
    }

}
