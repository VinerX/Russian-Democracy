using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Dangers : MonoBehaviour
{
    public void DangerHp(){
        string QuestTitle="Угроза: Слабое здоровье";
        string QuestText="Доктора подняли тревогу. Ваше состояние критическое"+
        " - еще чуть-чуть, и тело откажет. Какие действия следует принять?";
        Sprite ImageSprite = Resources.Load<Sprite>("Backgrounds/stress");
        byte AnswerCount = 1;
        string[] DisionText = new string[AnswerCount];
        string[] DisionTip = new string[AnswerCount];
        string[] DisionReq = new string[AnswerCount];
        string[] DisionLead = new string[AnswerCount];
        DisionText[0]="Лечь в больницу";
        DisionTip[0]="Ваша политическая власть ослабнет, но здоровье вы поправите";
        DisionReq[0]="Соблюдать постельный режим. (Требований нет)";
        DisionLead[0]="HPHealing"; //к ивенту лег в больницу



        //Собственно установка
        g.QuestTitle.GetComponent<Text>().text=QuestTitle;
        g.QuestText.GetComponent<Text>().text=QuestText;
        g.QuestImage.GetComponent<Image>().sprite=ImageSprite;


        
        
        for(byte i=1;i<=6;i++)
        {
            //Debug.Log("Answer"+i.ToString());
            if(i<=AnswerCount) {
                Transform Ans;
                Ans = g.AnswerPanel.GetComponent<RectTransform>().Find("Answer"+i.ToString() );
                //Ans.gameObject.SetActive(true);
                Ans.Find("AnswerText"+i.ToString()).GetComponent<Text>().text=DisionText[0];

                g.AnswerPanel.GetComponent<RectTransform>().Find("Answer"+i.ToString()).gameObject.SetActive(true);
                //GameObject.Find("Answer"+i.ToString()).GetComponent<RectTransform>().Find("AnswerText"+i.ToString()).GetComponent<Text>().text=DisionText[0];
                g.TextRequires.GetComponent<Text>().text = DisionReq[i-1];
                g.TextTip.GetComponent<Text>().text = DisionTip[i-1];
                }
                
            else {
                g.AnswerPanel.GetComponent<RectTransform>().Find("Answer"+i.ToString()).gameObject.SetActive(false);
            }
            



        }




        


    }




}
