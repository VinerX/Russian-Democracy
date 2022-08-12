using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Functions : MonoBehaviour
{   
    //[SerializeField] private SetAllStat SaS; // SetAllS()

    public void SetGrafics(){
        g.hp_s.size = (float)g.hp[0]/100;
        g.popularity_s.size =(float)g.popularity[0]/100;
        g.stress_s.size = (float)g.stress[0]/100;
        g.drinking_s.size = (float)g.drinking[0]/100;
    }

    public void SetChange(){
        g.hp[0]+=g.hp[1];
        g.stress[0]+=g.stress[1];
        g.drinking[0]+=g.drinking[1];
        g.popularity[0]+=g.popularity[1];
        
    }



    public void ScreensOff(bool active) {
    foreach(GameObject El in g.ScreensTag) {
        El.SetActive(active);
        //Debug.Log(El.name);
    }
    }

    public void ToDeath(string Type){
        g.SaS.ScreensOff(false);
        g.Screens.GetComponent<Transform>().Find("DefeatMenu").gameObject.SetActive(true);
        switch (Type)
        {
            case "hp":
                //GameObject.Find("DefeatBg").GetComponent<Image>().sprite("Die");
            break;

            default: 
            break;
        }   

    }


    public void CheckDef(){
        if (g.hp[0] <= 0f){
            ToDeath("hp");
        }
            



    }

    




}



