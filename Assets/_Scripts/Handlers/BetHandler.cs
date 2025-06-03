using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]


public class BetHandler : MonoBehaviour
{
    public GameObject table;
    
    
    public enum BetType
    {
        Zero,
        Odd,Even,
        Red,Black,
        High,Low,
        c1,c2,c3,
        d1,d2,d3,
    }
    public BetType betType;
    
    public List<GameObject> containedNumbers = new List<GameObject>();

    private void Start()
    {
        
        betType = gameObject.GetComponent<BetHandler>().betType;
        containedNumbers = gameObject.GetComponent<BetHandler>().containedNumbers;
        
    }
    

    public void OnSelectBetTypeButton()
    {
        gameObject.GetComponent<ButtonHighlighter>().SelectDeselectNumber();


        ChooseButtonsOfType();
    }

    public void ChooseButtonsOfType()
    {
        foreach(GameObject n in containedNumbers)
        {
            if (gameObject.GetComponent<ButtonHighlighter>().isSelected && !n.GetComponent<ButtonHighlighter>().isSelected)
            {
                n.GetComponent<ButtonHighlighter>().SelectButton();
            }
            else if (!gameObject.GetComponent<ButtonHighlighter>().isSelected && n.GetComponent<ButtonHighlighter>().isSelected)
            {
                n.GetComponent<ButtonHighlighter>().UnselectButton();
            }
        }
    }

    //public void AddNumbersToList()
    //{
    //    foreach (GameObject n in table.GetComponent<RewardHandler>().numObjects)
    //    {
    //        switch (gameObject.GetComponent<BetHandler>().betType)
    //        {
    //            case BetType.Zero:
    //                {
    //                    if (n.GetComponent<NumberValueCompute>().number == 0)
    //                    {
    //                        containedNumbers.Add(n);
    //                    }
    //                    break;
    //                }
    //            case BetType.Odd:
    //                {
    //                    if (n.GetComponent<NumberValueCompute>().isOdd)
    //                    {
    //                        containedNumbers.Add(n);
    //                    }
    //                    break;
    //                }
    //            case BetType.Even:
    //                {
    //                    if (!n.GetComponent<NumberValueCompute>().isOdd)
    //                    {
    //                        containedNumbers.Add(n);
    //                    }
    //                    break;
    //                }
    //            case BetType.Red:
    //                {
    //                    if (n.GetComponent<NumberValueCompute>().isRed)
    //                    {
    //                        containedNumbers.Add(n);
    //                    }
    //                    break;
    //                }
    //            case BetType.Black:
    //                {
    //                    if (!n.GetComponent<NumberValueCompute>().isRed)
    //                    {
    //                        containedNumbers.Add(n);
    //                    }
    //                    break;
    //                }
    //            case BetType.Low:
    //                {
    //                    if (n.GetComponent<NumberValueCompute>().isLow)
    //                    {
    //                        containedNumbers.Add(n);
    //                    }
    //                    break;
    //                }
    //            case BetType.High:
    //                {
    //                    if (!n.GetComponent<NumberValueCompute>().isLow)
    //                    {
    //                        containedNumbers.Add(n);
    //                    }
    //                    break;
    //                }
    //            case BetType.c1:
    //                {
    //                    if (n.GetComponent<NumberValueCompute>().column == NumberValueCompute.ColumnType.First)
    //                    {
    //                        containedNumbers.Add(n);
    //                    }
    //                    break;
    //                }
    //            case BetType.c2:
    //                {
    //                    if (n.GetComponent<NumberValueCompute>().column == NumberValueCompute.ColumnType.Second)
    //                    {
    //                        containedNumbers.Add(n);
    //                    }
    //                    break;
    //                }
    //            case BetType.c3:
    //                {
    //                    if (n.GetComponent<NumberValueCompute>().column == NumberValueCompute.ColumnType.Third)
    //                    {
    //                        containedNumbers.Add(n);
    //                    }
    //                    break;
    //                }
    //            case BetType.d1:
    //                {
    //                    if (n.GetComponent<NumberValueCompute>().dozen == NumberValueCompute.DozenType.First)
    //                    {
    //                        containedNumbers.Add(n);
    //                    }
    //                    break;
    //                }
    //            case BetType.d2:
    //                {
    //                    if (n.GetComponent<NumberValueCompute>().dozen == NumberValueCompute.DozenType.Second)
    //                    {
    //                        containedNumbers.Add(n);
    //                    }
    //                    break;
    //                }
    //            case BetType.d3:
    //                {
    //                    if (n.GetComponent<NumberValueCompute>().dozen == NumberValueCompute.DozenType.Third)
    //                    {
    //                        containedNumbers.Add(n);
    //                    }
    //                    break;
    //                }
    //        }
    //    }
    //}

    //public void ChooseButtonsOfType()
    //{
    //    foreach (GameObject n in table.GetComponent<RewardHandler>().numObjects)
    //    {
    //        switch (gameObject.GetComponent<BetHandler>().betType)
    //        {
    //            case BetType.Zero:
    //                {
    //                    if (n.GetComponent<NumberValueCompute>().number == 0)
    //                    {
    //                        if (gameObject.GetComponent<ButtonHighlighter>().isSelected && !n.GetComponent<ButtonHighlighter>().isSelected)
    //                        {
    //                            n.GetComponent<ButtonHighlighter>().SelectButton();
    //                        }
    //                        else if (!gameObject.GetComponent<ButtonHighlighter>().isSelected && n.GetComponent<ButtonHighlighter>().isSelected)
    //                        {
    //                            n.GetComponent<ButtonHighlighter>().UnselectButton();
    //                        }
    //                    }
    //                    break;
    //                }
    //            case BetType.Odd:
    //                {
    //                    if (n.GetComponent<NumberValueCompute>().isOdd)
    //                    {
    //                        if (gameObject.GetComponent<ButtonHighlighter>().isSelected && !n.GetComponent<ButtonHighlighter>().isSelected)
    //                        {
    //                            n.GetComponent<ButtonHighlighter>().SelectButton();
    //                        }
    //                        else if (!gameObject.GetComponent<ButtonHighlighter>().isSelected && n.GetComponent<ButtonHighlighter>().isSelected)
    //                        {
    //                            n.GetComponent<ButtonHighlighter>().UnselectButton();
    //                        }
    //                    }
    //                    break;
    //                }
    //            case BetType.Even:
    //                {
    //                    if (!n.GetComponent<NumberValueCompute>().isOdd)
    //                    {
    //                        if (gameObject.GetComponent<ButtonHighlighter>().isSelected && !n.GetComponent<ButtonHighlighter>().isSelected)
    //                        {
    //                            n.GetComponent<ButtonHighlighter>().SelectButton();
    //                        }
    //                        else if (!gameObject.GetComponent<ButtonHighlighter>().isSelected && n.GetComponent<ButtonHighlighter>().isSelected)
    //                        {
    //                            n.GetComponent<ButtonHighlighter>().UnselectButton();
    //                        }
    //                    }
    //                    break;
    //                }
    //            case BetType.Red:
    //                {
    //                    if (n.GetComponent<NumberValueCompute>().isRed)
    //                    {
    //                        if (gameObject.GetComponent<ButtonHighlighter>().isSelected && !n.GetComponent<ButtonHighlighter>().isSelected)
    //                        {
    //                            n.GetComponent<ButtonHighlighter>().SelectButton();
    //                        }
    //                        else if (!gameObject.GetComponent<ButtonHighlighter>().isSelected && n.GetComponent<ButtonHighlighter>().isSelected)
    //                        {
    //                            n.GetComponent<ButtonHighlighter>().UnselectButton();
    //                        }
    //                    }
    //                    break;
    //                }
    //            case BetType.Black:
    //                {
    //                    if (!n.GetComponent<NumberValueCompute>().isRed)
    //                    {
    //                        if (gameObject.GetComponent<ButtonHighlighter>().isSelected && !n.GetComponent<ButtonHighlighter>().isSelected)
    //                        {
    //                            n.GetComponent<ButtonHighlighter>().SelectButton();
    //                        }
    //                        else if (!gameObject.GetComponent<ButtonHighlighter>().isSelected && n.GetComponent<ButtonHighlighter>().isSelected)
    //                        {
    //                            n.GetComponent<ButtonHighlighter>().UnselectButton();
    //                        }
    //                    }
    //                    break;
    //                }
    //            case BetType.Low:
    //                {
    //                    if (n.GetComponent<NumberValueCompute>().isLow)
    //                    {
    //                        if (gameObject.GetComponent<ButtonHighlighter>().isSelected && !n.GetComponent<ButtonHighlighter>().isSelected)
    //                        {
    //                            n.GetComponent<ButtonHighlighter>().SelectButton();
    //                        }
    //                        else if (!gameObject.GetComponent<ButtonHighlighter>().isSelected && n.GetComponent<ButtonHighlighter>().isSelected)
    //                        {
    //                            n.GetComponent<ButtonHighlighter>().UnselectButton();
    //                        }
    //                    }
    //                    break;
    //                }
    //            case BetType.High:
    //                {
    //                    if (!n.GetComponent<NumberValueCompute>().isLow)
    //                    {
    //                        if (gameObject.GetComponent<ButtonHighlighter>().isSelected && !n.GetComponent<ButtonHighlighter>().isSelected)
    //                        {
    //                            n.GetComponent<ButtonHighlighter>().SelectButton();
    //                        }
    //                        else if (!gameObject.GetComponent<ButtonHighlighter>().isSelected && n.GetComponent<ButtonHighlighter>().isSelected)
    //                        {
    //                            n.GetComponent<ButtonHighlighter>().UnselectButton();
    //                        }
    //                    }
    //                    break;
    //                }
    //            case BetType.c1:
    //                {
    //                    if (n.GetComponent<NumberValueCompute>().column == NumberValueCompute.ColumnType.First)
    //                    {
    //                        if (gameObject.GetComponent<ButtonHighlighter>().isSelected && !n.GetComponent<ButtonHighlighter>().isSelected)
    //                        {
    //                            n.GetComponent<ButtonHighlighter>().SelectButton();
    //                        }
    //                        else if (!gameObject.GetComponent<ButtonHighlighter>().isSelected && n.GetComponent<ButtonHighlighter>().isSelected)
    //                        {
    //                            n.GetComponent<ButtonHighlighter>().UnselectButton();
    //                        }
    //                    }
    //                    break;
    //                }
    //            case BetType.c2:
    //                {
    //                    if (n.GetComponent<NumberValueCompute>().column == NumberValueCompute.ColumnType.Second)
    //                    {
    //                        if (gameObject.GetComponent<ButtonHighlighter>().isSelected && !n.GetComponent<ButtonHighlighter>().isSelected)
    //                        {
    //                            n.GetComponent<ButtonHighlighter>().SelectButton();
    //                        }
    //                        else if (!gameObject.GetComponent<ButtonHighlighter>().isSelected && n.GetComponent<ButtonHighlighter>().isSelected)
    //                        {
    //                            n.GetComponent<ButtonHighlighter>().UnselectButton();
    //                        }
    //                    }
    //                    break;
    //                }
    //            case BetType.c3:
    //                {
    //                    if (n.GetComponent<NumberValueCompute>().column == NumberValueCompute.ColumnType.Third)
    //                    {
    //                        if (gameObject.GetComponent<ButtonHighlighter>().isSelected && !n.GetComponent<ButtonHighlighter>().isSelected)
    //                        {
    //                            n.GetComponent<ButtonHighlighter>().SelectButton();
    //                        }
    //                        else if (!gameObject.GetComponent<ButtonHighlighter>().isSelected && n.GetComponent<ButtonHighlighter>().isSelected)
    //                        {
    //                            n.GetComponent<ButtonHighlighter>().UnselectButton();
    //                        }
    //                    }
    //                    break;
    //                }
    //            case BetType.d1:
    //                {
    //                    if (n.GetComponent<NumberValueCompute>().dozen == NumberValueCompute.DozenType.First)
    //                    {
    //                        if (gameObject.GetComponent<ButtonHighlighter>().isSelected && !n.GetComponent<ButtonHighlighter>().isSelected)
    //                        {
    //                            n.GetComponent<ButtonHighlighter>().SelectButton();
    //                        }
    //                        else if (!gameObject.GetComponent<ButtonHighlighter>().isSelected && n.GetComponent<ButtonHighlighter>().isSelected)
    //                        {
    //                            n.GetComponent<ButtonHighlighter>().UnselectButton();
    //                        }
    //                    }
    //                    break;
    //                }
    //            case BetType.d2:
    //                {
    //                    if (n.GetComponent<NumberValueCompute>().dozen == NumberValueCompute.DozenType.Second)
    //                    {
    //                        if (gameObject.GetComponent<ButtonHighlighter>().isSelected && !n.GetComponent<ButtonHighlighter>().isSelected)
    //                        {
    //                            n.GetComponent<ButtonHighlighter>().SelectButton();
    //                        }
    //                        else if (!gameObject.GetComponent<ButtonHighlighter>().isSelected && n.GetComponent<ButtonHighlighter>().isSelected)
    //                        {
    //                            n.GetComponent<ButtonHighlighter>().UnselectButton();
    //                        }
    //                    }
    //                    break;
    //                }
    //            case BetType.d3:
    //                {
    //                    if (n.GetComponent<NumberValueCompute>().dozen == NumberValueCompute.DozenType.Third)
    //                    {
    //                        if (gameObject.GetComponent<ButtonHighlighter>().isSelected && !n.GetComponent<ButtonHighlighter>().isSelected)
    //                        {
    //                            n.GetComponent<ButtonHighlighter>().SelectButton();
    //                        }
    //                        else if (!gameObject.GetComponent<ButtonHighlighter>().isSelected && n.GetComponent<ButtonHighlighter>().isSelected)
    //                        {
    //                            n.GetComponent<ButtonHighlighter>().UnselectButton();
    //                        }
    //                    }
    //                    break;
    //                }
    //        }
    //    }
    //}
}
