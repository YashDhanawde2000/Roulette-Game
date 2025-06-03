using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class ClearButton : MonoBehaviour
{
    public GameObject table, canvasUI, winningNumDisplay,winningAmtDisplay;
    public Button spinButton;
    public List<Button> buttons;
    

    private void Start()
    {
        buttons = new List<Button>();
        
        Button[] foundButtons = canvasUI.GetComponentsInChildren<Button>(true); // Get all buttons under the parent
        foreach (Button button in foundButtons)
        {
            buttons.Add(button); // Add each button to the list
        }
    }

    public void ClearButtonFunctionality()
    {
        // Loop through each button found
        foreach (Button button in buttons)
        {
            button.gameObject.GetComponent<ButtonHighlighter>().UnselectButton();
        }
        spinButton.GetComponent<EnableDisableButtons>().Start();
        winningNumDisplay.SetActive(false);
        winningAmtDisplay.SetActive(false);
        table.GetComponent<RewardHandler>().totalWinAmt = 0;
    }
}
