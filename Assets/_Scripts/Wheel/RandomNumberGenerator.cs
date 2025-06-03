using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomNumberGenerator : MonoBehaviour
{
    public int rnum;
    

    public void RNG()
    {
        rnum = Random.Range(0, 36);
        //Debug.Log(rnum);
    }
}
