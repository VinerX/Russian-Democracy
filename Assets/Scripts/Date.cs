using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Date : MonoBehaviour
{
    public int Year = 1991;
    public int Month = 8;
    public int Part = 4;
    public Text DateText;
    public void DataPlus()
    {
    Part += 1;
    if(Part > 4){
        Part = 1;
        Month += 1;
        if(Month > 12){
        Month = 1;
        Year += 1;
        }
    }
    DateText.text = Year + "." + Month + ".(" + Part + ").";
    }
}
