using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Init : MonoBehaviour
{

    // Самое начало игры
    void Start()
    {
    g.SaS.ScreensOff(false);
    g.AnswerPanel.SetActive(false);
    g.Screens.GetComponent<Transform>().Find("MainGame").gameObject.SetActive(true);
    g.SaS.SetGrafics();
    for(byte i=0;i<50;i++){
        g.ResultFor1[i]="";     
            }
    
    }

    public void init(){
        
    g.SaS.ScreensOff(false);
    g.AnswerPanel.SetActive(false);
    g.Screens.GetComponent<Transform>().Find("MainGame").gameObject.SetActive(true);
    g.SaS.SetGrafics();




    }
  
}
