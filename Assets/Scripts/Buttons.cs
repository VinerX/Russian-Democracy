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
            g.Event.FreeDay();
        }
        else {
            Debug.Log("Видно, что есть квесты");
            g.Event.BroadcastMessage(g.QuestGroup[0]);


        }
        OnTogglesInteract();
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
        string Res;
        g.ResultDict.TryGetValue("Answer"+AnserId.ToString(), out Res);
        g.ResultGroup.Add(Res);
        g.Results+=1; //Временно
        OffTogles(AnserId);
        if( !g.SolvedQuests.Contains(g.QuestNow))
        { 
        g.SolvedQuests.Add(g.QuestNow);
        g.QuestToSolve-=1;
        }
    }
    public void Toggle2(){
        int AnserId=2;
        string Res;
        g.ResultDict.TryGetValue("Answer"+AnserId.ToString(), out Res);
        g.ResultGroup.Add(Res);
        OffTogles(AnserId);
        if( !g.SolvedQuests.Contains(g.QuestNow))
        { 
        g.SolvedQuests.Add(g.QuestNow);
        g.QuestToSolve-=1;
        }
        
    }
    public void Toggle3(){
        int AnserId=3;
        string Res;
        g.ResultDict.TryGetValue("Answer"+AnserId.ToString(), out Res);
        g.ResultGroup.Add(Res);
        OffTogles(AnserId);
        if( !g.SolvedQuests.Contains(g.QuestNow))
        { 
        g.SolvedQuests.Add(g.QuestNow);
        g.QuestToSolve-=1;
        }
        
    }

    public void Toggle4(){
        int AnserId=4;
        string Res;
        g.ResultDict.TryGetValue("Answer"+AnserId.ToString(), out Res);
        g.ResultGroup.Add(Res);
        OffTogles(AnserId);
        if( !g.SolvedQuests.Contains(g.QuestNow))
        { 
        g.SolvedQuests.Add(g.QuestNow);
        g.QuestToSolve-=1;
        }
        
    }

    public void Toggle5(){
        int AnserId=5;
        string Res;
        g.ResultDict.TryGetValue("Answer"+AnserId.ToString(), out Res);
        g.ResultGroup.Add(Res);
        OffTogles(AnserId);
        if( !g.SolvedQuests.Contains(g.QuestNow))
        { 
        g.SolvedQuests.Add(g.QuestNow);
        g.QuestToSolve-=1;
        }
       
    }

    public void Toggle6(){
        int AnserId=6;
        string Res;
        g.ResultDict.TryGetValue("Answer"+AnserId.ToString(), out Res);
        g.ResultGroup.Add(Res);
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
        g.ResultDict.Clear();
        int QuestId = g.QuestGroup.IndexOf(g.QuestNow);
        Debug.Log("Итого квестов: "+ g.QuestGroup.Count.ToString());
        if (QuestId == 0) { //Если край левый 
            Debug.Log("К другому концу");
            QuestId = g.QuestGroup.Count-1;
            g.Event.BroadcastMessage( g.QuestGroup[QuestId]);
            g.QuestNow= g.QuestGroup[QuestId];
            
        }
        else {
            Debug.Log("Левее");
            QuestId -=1; //Квест левее
            g.Event.BroadcastMessage( g.QuestGroup[QuestId]);
            g.QuestNow= g.QuestGroup[QuestId];
        }
        OnTogglesInteract();
    }

    public void NextQuest(){
        g.ResultDict.Clear(); 
        int QuestId = g.QuestGroup.IndexOf(g.QuestNow);
        Debug.Log("Итого квестов: "+ g.QuestGroup.Count.ToString());
        if (QuestId == g.QuestGroup.Count-1) { //Если край левый 
            Debug.Log("К другому концу");
            QuestId = 0;
            g.Event.BroadcastMessage( g.QuestGroup[QuestId]);
            g.QuestNow= g.QuestGroup[QuestId];
            
        }
        else {
            Debug.Log("Правее");
            QuestId +=1; //Квест левее
            g.Event.BroadcastMessage( g.QuestGroup[QuestId]);
            g.QuestNow= g.QuestGroup[QuestId];
        }
        OnTogglesInteract();
    }

    public void Finish(){
        if (g.QuestToSolve==0){
            g.Screens.GetComponent<Transform>().Find("QuestMenu").gameObject.SetActive(false);
            
            g.QuestGroup.Clear();
            g.SolvedQuests.Clear();
            g.ResultDict.Clear();

            g.Screens.GetComponent<Transform>().Find("ResultMenu").gameObject.SetActive(true);
            Debug.Log("Отсылаю... "+g.ResultGroup[0].ToString());
            g.Result.BroadcastMessage( g.ResultGroup[0]);
            g.ResultGroup.Remove(g.ResultNow);
            g.Results-=1;
            
        }
    }


    public void NextResult(){
        Debug.Log("Есть нажатие");
        if (g.Results>1) {
            Debug.Log("Отсылаю... "+g.ResultGroup[0].ToString());
            g.Result.BroadcastMessage( g.ResultGroup[0]);
            g.ResultGroup.Remove(g.ResultNow);
            g.Results-=1;
        }
        else {
            g.SaS.SetChange();
            g.SaS.SetGrafics();
            g.Screens.GetComponent<Transform>().Find("ResultMenu").gameObject.SetActive(false);
            g.Screens.GetComponent<Transform>().Find("MainGame").gameObject.SetActive(true);
            g.ResultGroup.Clear();
            g.Results=0;
        }
    }





}

