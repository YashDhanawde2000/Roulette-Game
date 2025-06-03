using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class ButtonHighlighter : MonoBehaviour
{
    
    
    Button numButton;
    ColorBlock colors;
    Color32 normalColor, selectedColor, disabledColor;

    public bool isSelected; 
    

    private void Start()
    {
        
        numButton = gameObject.GetComponent<Button>();
        
        if (gameObject.GetComponent<BetHandler>() == null)
        { 
            numButton.onClick.AddListener(gameObject.GetComponent<ButtonHighlighter>().SelectDeselectNumber); 
        }
        else 
        { 
            numButton.onClick.AddListener(gameObject.GetComponent<BetHandler>().OnSelectBetTypeButton); 
        }

        colors = gameObject.GetComponent<Button>().colors;
        normalColor = colors.normalColor;
        selectedColor = colors.selectedColor;
        disabledColor = colors.disabledColor;
        colors.selectedColor = normalColor;

        isSelected = gameObject.GetComponent<ButtonHighlighter>().isSelected;
        
    }

    public void SelectDeselectNumber()
    {
        if (!isSelected) 
        {
            SelectButton(); 
        }
        //else
        //{
        //    UnselectButton();
        //}
               
    }

    public void SelectButton()
    {       
        isSelected = true;
        colors.normalColor = selectedColor;
        colors.selectedColor = selectedColor;
        colors.disabledColor = selectedColor;
        gameObject.GetComponent<Button>().colors = colors;       
    }

    public void UnselectButton()
    {       
        isSelected = false;
        colors.normalColor = normalColor;
        colors.selectedColor = normalColor;
        colors.disabledColor = disabledColor;
        gameObject.GetComponent<Button>().colors = colors;       
    }

    


}
