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
        float[] F = new float[5];
        void AddSphere(string name, byte allpower, byte PrivSob, byte GosCorp, byte GosSob){
            F[0]=allpower;
            F[1]=PrivSob;
            F[2]=GosCorp;
            F[3]=GosSob;
            g.Econom.Add(name,F);
        }


        
        
        F[0] = 164.1f;
        g.Econom.Add("Income",F);

        F[0] = 180.9f;
        g.Econom.Add("Disincome",F);

        F[0] = 180.9f-164.1f;
        g.Econom.Add("Balance",F);





        // Сферы экономики
        AddSphere("APK",30,5,10,15);
        AddSphere("Maining",30,5,10,15);
        AddSphere("LightInd",30,5,10,15);
        AddSphere("HeavyInd",30,5,10,15);
        AddSphere("ArmyInd",30,5,10,15);
        //AddSphere("APK",30,5,10,15);
        AddSphere("Chem",10,0,0,10);
        AddSphere("Building",30,5,10,15);
        AddSphere("Servises",30,5,10,15);
        AddSphere("Infrastracture",30,5,10,15);
        AddSphere("Innovation",30,5,10,15);



    }
    public static void HideAllStat(){

        GameObject.Find("MainFinStat").SetActive(false);
        try{
            GameObject.Find("EconomyStat").SetActive(false);
        }
        catch {}
        // var SG = GameObject.Find("StatTopics").GetComponentsInChildren<Transform>(true);
        // foreach (var item in SG)
        // {
        //     item.gameObject.SetActive(false);
        // }
    }


    public static void EcChange(){
        YearBalance=YearIncome-YearDisIncome;


    }

    public static void SetEcForStat(){
        //byte n=1;
        //Stat1.text=$"Годовой доход - {YearIncome} млрд";
        //Stat2.text=$"Годовой расход - {YearDisIncome} млрд";
            
        //Stat3.text=$"Годовой баланс - {YearBalance} млрд";
        
        
        
        //GameObject.Find($"Stat{n}").GetComponent<Text>.text=YearIncome.ToString;

        // for(byte i;i<10;i++)


        
    }
    
        
    




}