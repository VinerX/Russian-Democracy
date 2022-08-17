using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public static class Ec
{
    public static float YearIncome=246.4f;
    public static float YearDisIncome=266.2f;
    public static float YearBalance=YearIncome-YearDisIncome;

    public static Text Stat1;
    public static Text Stat2;
    public static Text Stat3;
    
    public static void SetStartStat(){
        Stat1 = GameObject.Find("Stat1").GetComponent<Text>();
        Stat2= GameObject.Find("Stat2").GetComponent<Text>();
        Stat3= GameObject.Find("Stat3").GetComponent<Text>();
    }

    public static void EcChange(){
        YearBalance=YearIncome-YearDisIncome;


    }

    public static void SetEcForStat(){
        //byte n=1;
        Stat1.text=$"Годовой доход - {YearIncome} млрд";
        Stat2.text=$"Годовой расход - {YearDisIncome} млрд";
            
        Stat3.text=$"Годовой баланс - {YearBalance} млрд";
        
        
        
        //GameObject.Find($"Stat{n}").GetComponent<Text>.text=YearIncome.ToString;

        // for(byte i;i<10;i++)


        
    }
    
        
    




}