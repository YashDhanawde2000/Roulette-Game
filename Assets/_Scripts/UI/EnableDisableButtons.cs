using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnableDisableButtons : MonoBehaviour
{
    public Transform[] parentObjects; // Parent object containing buttons
    public Transform tableUIGrp, chipsUIGrp, buttonUIGrp;
    public Button clearButton;

    public void Start()
    {
        TableButtonsDisable();
        SpinButtonDisable();
        ChipButtonsEnable();
    }

    public void PressClearBetButton()
    {
        clearButton.interactable = true;

        //AllButtonsEnable();
        //clearButton.onClick.Invoke();
    }
    

    public void AllButtonsDisable()
    {
        foreach (Transform parentObject in parentObjects)
        // Find all buttons under the parent object
        {
            Button[] buttons = parentObject.GetComponentsInChildren<Button>();

            // Loop through each button found
            foreach (Button button in buttons)
            {   // Disable the interactable property of the button                   
                button.interactable = false;               
            }
        }

        
        Invoke(nameof(PressClearBetButton), 15f);
    }
    public void AllButtonsEnable()
    {
        foreach (Transform parentObject in parentObjects)
        // Find all buttons under the parent object
        {
            Button[] buttons = parentObject.GetComponentsInChildren<Button>();

            // Loop through each button found
            foreach (Button button in buttons)
            {   // Disable the interactable property of the button                   
                button.interactable = true;
            }
        }
    }

    public void TableButtonsDisable()
    {
        Button[] buttons = tableUIGrp.GetComponentsInChildren<Button>();

        // Loop through each button found
        foreach (Button button in buttons)
        {
            // Disable the interactable property of the button
            button.interactable = false;         
        }
    }
    public void TableButtonsEnable()
    {
        Button[] buttons = tableUIGrp.GetComponentsInChildren<Button>();

        // Loop through each button found
        foreach (Button button in buttons)
        {
            // Disable the interactable property of the button
            button.interactable = true;
        }
    }


    public void ChipButtonsDisable()
    {
        Button[] buttons = chipsUIGrp.GetComponentsInChildren<Button>();

        // Loop through each button found
        foreach (Button button in buttons)
        {
            // Disable the interactable property of the button
            button.interactable = false;
        }
    }
    public void ChipButtonsEnable()
    {
        Button[] buttons = chipsUIGrp.GetComponentsInChildren<Button>();

        // Loop through each button found
        foreach (Button button in buttons)
        {
            // Disable the interactable property of the button
            button.interactable = true;
        }
    }


    public void SpinButtonDisable()
    {
        Button[] buttons = buttonUIGrp.GetComponentsInChildren<Button>();

        // Loop through each button found
        foreach (Button button in buttons)
        {
            // Disable the interactable property of the button
            button.interactable = false;
        }
    }
    public void SpinButtonEnable()
    {
        Button[] buttons = buttonUIGrp.GetComponentsInChildren<Button>();

        // Loop through each button found
        foreach (Button button in buttons)
        {
            // Disable the interactable property of the button
            button.interactable = true;
        }
    }
}
