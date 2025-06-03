using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class BetValueDisplay : MonoBehaviour
{
    public GameObject tbvHolder;
    TMP_Text tbvText;

    // Start is called before the first frame update
    void Start()
    {
        tbvText = gameObject.GetComponent<TMP_Text>();
    }

    // Update is called once per frame
    void Update()
    {
        tbvText.text = " " + tbvHolder.GetComponent<BetValueController>().totalBetValue.ToString();
    }
}
