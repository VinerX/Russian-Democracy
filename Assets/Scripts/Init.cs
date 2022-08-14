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

    
    }

    public void init(){
        
    g.SaS.ScreensOff(false);
    g.AnswerPanel.SetActive(false);
    g.Screens.GetComponent<Transform>().Find("MainGame").gameObject.SetActive(true);
    g.SaS.SetGrafics();




    }
  
}
