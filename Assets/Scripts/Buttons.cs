using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Buttons : MonoBehaviour
{


    //Поменять инфо или выбор
    private bool i=false;
    public void ChangeQuest(){
        if(i==false){
            g.AnswerPanel.SetActive(true);
            g.QuestPanel.SetActive(false);
            i = true;
        }
        else {
            g.AnswerPanel.SetActive(false);
            g.QuestPanel.SetActive(true);
            i = false;
        }

    }
    //Доки в главном меню
    public void DocsMain(){
        g.Screens.GetComponent<Transform>().Find("QuestMenu").gameObject.SetActive(true);
        g.Screens.GetComponent<Transform>().Find("MainGame").gameObject.SetActive(false);
        g.Dan.DangerHp();


    }
    
    //Вернуться в главное меню
    public void ReturnToMain(){
        g.SaS.ScreensOff(false);
        g.Screens.GetComponent<Transform>().Find("MainGame").gameObject.SetActive(true);
    }

}
