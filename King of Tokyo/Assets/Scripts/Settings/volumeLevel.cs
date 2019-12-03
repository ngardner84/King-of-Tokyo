using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class volumeLevel : MonoBehaviour
{
    Text percentageText;

    void Start()
    {
        percentageText = GetComponent<Text>();
    }

    public void textUpdate(float newValue)
    {
        percentageText.text = Mathf.RoundToInt((newValue * 100 / 80 * -1) - (newValue * 1.25f)) + "%";
    }
}