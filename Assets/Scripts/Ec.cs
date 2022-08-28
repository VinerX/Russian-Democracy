using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public static class Ec
{
    public static float Income=164.1f;
    public static float DisIncome=180.9f;
    public static float Balance=Income-DisIncome;

    public static Text Stat1= g.MainFinStat.GetComponent<Transform>().Find("StatIncome").gameObject.GetComponent<Text>();
    public static Text Stat2= g.MainFinStat.GetComponent<Transform>().Find("StatDisincome").gameObject.GetComponent<Text>();
    public static Text Stat3= g.MainFinStat.GetComponent<Transform>().Find("StatBalance").gameObject.GetComponent<Text>();
    
    public static void SetStartStat(){
        
        void AddSphere(string name, byte allpower, byte PrivSob, byte GosCorp, byte GosSob){
            float[] F = new float[5];
            F[0]=allpower;
            F[1]=PrivSob;
            F[2]=GosCorp;
            F[3]=GosSob;
            g.Econom.Add(name,F);
        }



        // Сферы экономики
        AddSphere("APK",50,5,20,25);
        AddSphere("Maining",50,0,0,50);
        AddSphere("LightInd",30,5,10,15);
        AddSphere("HeavyInd",45,0,0,45);
        AddSphere("ArmyInd",65,0,0,65);
        AddSphere("Chem",10,0,0,10);
        AddSphere("Building",30,5,0,25);
        AddSphere("Servises",30,15,10,5);
        AddSphere("Infrastracture",40,5,10,25);
        AddSphere("Innovation",0,0,0,0);







        //графика
        Stat1.text="Годовой доход - " + Ec.Income + " млрд";
        Stat2.text="Годовой расход - " + Ec.DisIncome + " млрд";
        float f;
        
        Stat3.text="Годовой баланс - " + (Ec.Income-Ec.DisIncome) + " млрд";    



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
        //YearBalance=YearIncome-YearDisIncome;


    }

    public static void SetEcForStat(){
        float f;
        
   


        
    }
    
        
    




}