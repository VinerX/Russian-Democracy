using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Buttons : MonoBehaviour
{

    //Тут ловлю все кнопки

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
        


    }
    
    //Вернуться в главное меню
    public void ReturnToMain(){
        g.SaS.ScreensOff(false);
        g.Screens.GetComponent<Transform>().Find("MainGame").gameObject.SetActive(true);
    }



    public void Toggle1(){
        int AnserId=1;
        GameObject.Find("Answer"+AnserId.ToString()).gameObject.GetComponent<Toggle>();
        OffTogles(AnserId);
    }
    public void Toggle2(){
        int AnserId=2;
        GameObject.Find("Answer"+AnserId.ToString());
        OffTogles(AnserId);
    }
    public void Toggle3(){
        int AnserId=3;
        GameObject.Find("Answer"+AnserId.ToString());
        OffTogles(AnserId);
    }

    public void Toggle4(){
        int AnserId=4;
        GameObject.Find("Answer"+AnserId.ToString());
        OffTogles(AnserId);
    }

    public void Toggle5(){
        int AnserId=5;
        GameObject.Find("Answer"+AnserId.ToString());
        OffTogles(AnserId);
    }

    public void Toggle6(){
        int AnserId=6;
        GameObject.Find("Answer"+AnserId.ToString());
        OffTogles(AnserId);
    }

    public void OffTogles(int id){
        for (byte i=1; i<=6;i++){
            Toggle AnsT = g.AnswerPanel.GetComponent<RectTransform>().Find("Answer"+i.ToString()).gameObject.GetComponent<Toggle>();
            if(id==i){
                
                AnsT.interactable=false;
            }
            else {
                AnsT.interactable=true;
                }
        }
        


        //Ans.Find("Answer"+i.ToString()).GetComponent<Text>().text=DisionText[0];
    }

    public void LastQuest(){

    }

    public void NextQuest(){

    }

    public void Finish(){
        g.Screens.GetComponent<Transform>().Find("QuestMenu").gameObject.SetActive(false);
        g.Screens.GetComponent<Transform>().Find("MainGame").gameObject.SetActive(true);
        g.SaS.SetChange();
        g.SaS.SetGrafics();
    
    }
}
