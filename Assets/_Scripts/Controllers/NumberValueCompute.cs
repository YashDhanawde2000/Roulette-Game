using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NumberValueCompute : MonoBehaviour
{
    public int number;

    public bool isOdd, isLow, isRed;
    
    public enum DozenType
    {
        First, Second, Third
    }
    public DozenType dozen;
    public enum ColumnType
    {
        First, Second, Third
    }
    public ColumnType column;

    private void Start()
    {   
        number = int.Parse(gameObject.name);
        gameObject.GetComponent<NumberValueCompute>().number = number;

        // Check if num is ODD 
        if(number % 2 == 0)
        {
            isOdd = false;  

        }
        else 
        { 
            isOdd = true;   
        }

        // Check if num is between 1-18
        if (number >= 1 &&  number <= 18) 
        {
            isLow = true;
        }
        else if (number >= 19 && number <= 36)
        {
            isLow = false;
        }

        // Check which DOZEN num belongs to
        if (number >= 1 && number <= 12)
        {
            dozen = DozenType.First;
        }
        else if(number >= 13 && number <= 24)
        {
            dozen = DozenType.Second;
        }
        else if (number >= 25 &&  number <= 36)
        {
            dozen = DozenType.Third;
        }

       
         
    }
}
