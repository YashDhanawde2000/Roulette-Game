using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

[System.Serializable]
public class RouletteBet
{
    public int betValue, winningAmt;
    public GameObject buttonPressed;
    public int amountMultiplier;

    public RouletteBet(int betvalue, GameObject pressedbutton, int amtmultiplier, int winningamt )
    {
        betValue = betvalue;
        buttonPressed = pressedbutton;
        amountMultiplier = amtmultiplier;
        winningAmt = winningamt;
    }
}

public class BetTracker : MonoBehaviour
{   
    //public GameObject currentButtonPressed;
    public int currentBetValue, winningAmt, currentBetMultiplier;
    public GameObject clickedButton;

    public List<RouletteBet> placedBets = new List<RouletteBet>();

    public void PlaceBet()
    {
        RouletteBet newBet = new RouletteBet(currentBetValue, clickedButton, currentBetMultiplier,winningAmt);
        placedBets.Add(newBet);
    }

    public void ClearBets()
    {
        placedBets.Clear();
        currentBetValue = 0;
        currentBetMultiplier = 0;
        clickedButton = null;
    }


}
