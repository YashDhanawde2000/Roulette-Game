using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BetValueController : MonoBehaviour
{
    public int totalBetValue;


    public List<GameObject> chipsList = new List<GameObject>();

    private void Start()
    {
        totalBetValue = 0;
    }

    public void UpdateBetValues()
    {
        totalBetValue = 0;
        foreach (GameObject chip in chipsList)
        {
            totalBetValue += chip.gameObject.GetComponent<ChipButtonValue>().currentChipValue;
            Debug.Log("Total Bet Value = " + totalBetValue);
        }
    }

    public void ClearBets()
    {
        totalBetValue = 0;

        foreach (GameObject chip in chipsList)
        {
            chip.gameObject.GetComponent<ChipButtonValue>().currentChipValue = 0;
            Debug.Log("Total Bet Value = " + totalBetValue);
        }
    }
}
