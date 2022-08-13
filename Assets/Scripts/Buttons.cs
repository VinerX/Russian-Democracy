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
        if (g.QuestGroup.Count==0){
            g.QuestGroup.Add("FreeDay");
            g.QuestToSolve+=1;
            g.Dan.FreeDay();
        }
        else {
            Debug.Log("Видно, что есть квесты");
            g.Dan.BroadcastMessage(g.QuestGroup[0]);


        }
        g.AnswerPanel.SetActive(false);
        g.QuestPanel.SetActive(true);

        for (byte i=1; i<=6;i++){
            Toggle AnsT = g.AnswerPanel.GetComponent<RectTransform>().Find("Answer"+i.ToString()).gameObject.GetComponent<Toggle>();
            AnsT.interactable=true;
            AnsT.isOn=false;
        }
        
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
        
        OffTogles(AnserId);
        if( !g.SolvedQuests.Contains(g.QuestNow))
        { 
        g.SolvedQuests.Add(g.QuestNow);
        g.QuestToSolve-=1;
        }
    }
    public void Toggle2(){
        int AnserId=2;
        
        OffTogles(AnserId);
        if( !g.SolvedQuests.Contains(g.QuestNow))
        { 
        g.SolvedQuests.Add(g.QuestNow);
        g.QuestToSolve-=1;
        }
        
    }
    public void Toggle3(){
        int AnserId=3;
        
        OffTogles(AnserId);
        if( !g.SolvedQuests.Contains(g.QuestNow))
        { 
        g.SolvedQuests.Add(g.QuestNow);
        g.QuestToSolve-=1;
        }
        
    }

    public void Toggle4(){
        int AnserId=4;
        
        OffTogles(AnserId);
        if( !g.SolvedQuests.Contains(g.QuestNow))
        { 
        g.SolvedQuests.Add(g.QuestNow);
        g.QuestToSolve-=1;
        }
        
    }

    public void Toggle5(){
        int AnserId=5;
        
        OffTogles(AnserId);
        if( !g.SolvedQuests.Contains(g.QuestNow))
        { 
        g.SolvedQuests.Add(g.QuestNow);
        g.QuestToSolve-=1;
        }
       
    }

    public void Toggle6(){
        int AnserId=6;
        
        OffTogles(AnserId);
        if( !g.SolvedQuests.Contains(g.QuestNow))
        { 
        g.SolvedQuests.Add(g.QuestNow);
        g.QuestToSolve-=1;
        }
       
    }

    public void OffTogles(int id){
        Debug.Log("Квестов осталось решить"+(g.QuestToSolve-1).ToString());
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
    public void OnTogglesInteract(){
        for (byte i=1; i<=6;i++){
            if ( !g.SolvedQuests.Contains(g.QuestNow))  {
            Toggle AnsT = g.AnswerPanel.GetComponent<RectTransform>().Find("Answer"+i.ToString()).gameObject.GetComponent<Toggle>();
            AnsT.interactable=true;
            AnsT.isOn=false;
        }}}



    //https://metanit.com/sharp/tutorial/4.5.php
    public void LastQuest(){
        
        int QuestId = g.QuestGroup.IndexOf(g.QuestNow);
        Debug.Log("Итого квестов: "+ g.QuestGroup.Count.ToString());
        if (QuestId == 0) { //Если край левый 
            Debug.Log("К другому концу");
            QuestId = g.QuestGroup.Count-1;
            g.Dan.BroadcastMessage( g.QuestGroup[QuestId]);
            g.QuestNow= g.QuestGroup[QuestId];
            
        }
        else {
            Debug.Log("Левее");
            QuestId -=1; //Квест левее
            g.Dan.BroadcastMessage( g.QuestGroup[QuestId]);
            g.QuestNow= g.QuestGroup[QuestId];
        }
        OnTogglesInteract();
    }

    public void NextQuest(){

    }

    public void Finish(){
        if (g.QuestToSolve==0){
            g.Screens.GetComponent<Transform>().Find("QuestMenu").gameObject.SetActive(false);
            g.Screens.GetComponent<Transform>().Find("MainGame").gameObject.SetActive(true);
            g.QuestGroup.Clear();
            g.SolvedQuests.Clear();
            g.SaS.SetChange();
            g.SaS.SetGrafics();
        }
    }
}
