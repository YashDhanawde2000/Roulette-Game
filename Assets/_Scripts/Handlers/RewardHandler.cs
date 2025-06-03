using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using System.Linq;

public class RewardHandler : MonoBehaviour
{
    //public NumberValueCompute numValCompute;
    public RotateBall RB;
    public BetValueController bvc;
    public BetTracker bt;
    public GameObject spinBtn, winningNumDisplay, winningAmtDisplay;

    public int totalWinAmt;

    public GameObject numParent, winningNum;
    public List<GameObject> numObjects;
    public List<Button> numButtons;
    public List<int> numbers;

    private void Start()
    {
        Invoke(nameof(SetLists), 2f);
        bt = gameObject.GetComponent<BetTracker>();
        totalWinAmt = gameObject.GetComponent<RewardHandler>().totalWinAmt;
    }

    public void SetLists()
    {
        RectTransform[] allNums =   numParent.GetComponentsInChildren<RectTransform>();
        numObjects = new List<GameObject>();
        numButtons = new List<Button>();
        numbers = new List<int>();
        foreach (RectTransform t in allNums)
        {
            numObjects.Add(t.gameObject);            
        }

        numObjects.Remove(numParent);

        foreach (GameObject n in numObjects)
        { 
            numButtons.Add(n.GetComponent<Button>());
            numbers.Add(n.GetComponent<NumberValueCompute>().number);
        }
        
    }

    public void ComputeReward()
    {
        GetWinningNumber();
        GetWinningAmount();
        Invoke(nameof(CheckIfWin), 10f);        // deleteinvoke after testing
             
    }
    public void GetWinningNumber()
    {
        foreach (GameObject n in numObjects)
        {
            if (n.GetComponent<NumberValueCompute>().number == RB.selectedNumber)
            {
                Debug.Log(n.name + " is the number that has won");
                gameObject.GetComponent<RewardHandler>().winningNum = n;
            }
        }
    }

    public void GetWinningAmount()
    {
        foreach (RouletteBet bet in bt.placedBets)
        {
            if (bet.buttonPressed.GetComponent<Bet>().outsideBet)
            {
                if(bet.buttonPressed.GetComponent<BetHandler>().containedNumbers.Contains(winningNum))
                {
                    bet.winningAmt = bet.betValue * bet.amountMultiplier;
                }
                else
                {
                    bet.winningAmt = 0;
                }
            }
            else
            {
                if(bet.buttonPressed == winningNum)
                {
                    bet.winningAmt = bet.betValue * bet.amountMultiplier;
                }
                else
                {
                    bet.winningAmt = 0;
                }
            }

            totalWinAmt += bet.winningAmt;
        }

    }

    public void CheckIfWin()
    {
        if (winningNum.GetComponent<ButtonHighlighter>().isSelected)
        {
            winningNumDisplay.SetActive(true);
            winningAmtDisplay.SetActive(true);
            winningNumDisplay.GetComponent<TMP_Text>().text = winningNum.name;
            winningAmtDisplay.GetComponent<TMP_Text>().text = "You WON: " + totalWinAmt;
        }
        else
        {
            winningNumDisplay.SetActive(true);
            winningAmtDisplay.SetActive(true);
            winningNumDisplay.GetComponent<TMP_Text>().text = winningNum.name;
            winningAmtDisplay.GetComponent<TMP_Text>().text = "TRY AGAIN";
        }
        

        spinBtn.GetComponent<SpinButton>().isSpinning = false;
        
    }

    

}
