using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Events : MonoBehaviour
{



    //Блок предупредительных ивентов
    
    public void DangerHp(){
        g.QuestNow="DangerHp";
        string QuestTitle="Угроза: Слабое здоровье";
        string QuestText="Доктора подняли тревогу. Ваше состояние критическое"+
        " - еще чуть-чуть, и тело откажет. Какие действия следует принять?";
        Sprite ImageSprite = Resources.Load<Sprite>("Backgrounds/stress");
        byte AnswerCount = 1;
        string[] DisionText = new string[AnswerCount];
        string[] DisionTip = new string[AnswerCount];
        string[] DisionReq = new string[AnswerCount];
        string[] DisionLead = new string[AnswerCount];



        byte b =0;
        DisionText[b]="Лечь в больницу";
        DisionTip[b]="Ваша политическая власть ослабнет, но здоровье вы поправите";
        DisionReq[b]="Соблюдать постельный режим. (Требований нет)";
        DisionLead[b]="HPHealing"; //к ивенту лег в больницу
 


        //Собственно установка
        g.QuestTitle.GetComponent<Text>().text=QuestTitle;
        g.QuestText.GetComponent<Text>().text=QuestText;
        g.QuestImage.GetComponent<Image>().sprite=ImageSprite;
        

        
        
        //Проход по тоглам
        for(byte i=1;i<=6;i++)
        {
            //Debug.Log("Answer"+i.ToString());
            if(i<=AnswerCount) {
                Transform Ans;
                Ans = g.AnswerPanel.GetComponent<RectTransform>().Find("Answer"+i.ToString() );
                Ans.Find("AnswerText"+i.ToString()).GetComponent<Text>().text=DisionText[i-1];
                g.ResultDict.Add( ("Answer"+i.ToString()), DisionLead[i-1] ) ;
                g.AnswerPanel.GetComponent<RectTransform>().Find("Answer"+i.ToString()).gameObject.SetActive(true);
                g.TextRequires.GetComponent<Text>().text = DisionReq[i-1];
                g.TextTip.GetComponent<Text>().text = DisionTip[i-1];
                }
                
            else {
                g.AnswerPanel.GetComponent<RectTransform>().Find("Answer"+i.ToString()).gameObject.SetActive(false);
            }
            



        }




        


    }
    public void DangerDrinking(){
        g.QuestNow="DangerDrinking";
        string QuestTitle="Угроза: злоупотребление спиртным";
        string QuestText="Остановитесь. Хватит пить водку. Вы так долго не протянете";
        //" - еще чуть-чуть, и тело откажет. Какие действия следует принять?";
        Sprite ImageSprite = Resources.Load<Sprite>("Backgrounds/Drinking");
        byte AnswerCount = 2;
        string[] DisionText = new string[AnswerCount];
        string[] DisionTip = new string[AnswerCount];
        string[] DisionReq = new string[AnswerCount];
        string[] DisionLead = new string[AnswerCount];



        byte b =0;
        DisionText[b]="Ладно, недельку трезвым побудем...";
        DisionTip[b]="-Алкоголизм, + стресс";
        DisionReq[b]="Держитесь (Требований нет)";
        DisionLead[b]="DrinkingStop"; //к ивенту лег в больницу

        b+=1;
        DisionText[b]="Еще рюмочку";
        DisionTip[b]="+Алкоголизм, - стресс";
        DisionReq[b]="Зачем? (Требований нет)";
        DisionLead[b]="DrinkingCont"; //к ивенту лег в больницу



        //Собственно установка
        g.QuestTitle.GetComponent<Text>().text=QuestTitle;
        g.QuestText.GetComponent<Text>().text=QuestText;
        g.QuestImage.GetComponent<Image>().sprite=ImageSprite;


        
        
        //Проход по тоглам
        for(byte i=1;i<=6;i++)
        {
            //Debug.Log("Answer"+i.ToString());
            if(i<=AnswerCount) {
                Transform Ans;
                Ans = g.AnswerPanel.GetComponent<RectTransform>().Find("Answer"+i.ToString() );
                Ans.Find("AnswerText"+i.ToString()).GetComponent<Text>().text=DisionText[i-1];
                g.ResultDict.Add( ("Answer"+i.ToString()), DisionLead[i-1] ) ;
                g.AnswerPanel.GetComponent<RectTransform>().Find("Answer"+i.ToString()).gameObject.SetActive(true);
                g.TextRequires.GetComponent<Text>().text = DisionReq[i-1];
                g.TextTip.GetComponent<Text>().text = DisionTip[i-1];
                }
                
            else {
                g.AnswerPanel.GetComponent<RectTransform>().Find("Answer"+i.ToString()).gameObject.SetActive(false);
            }
            



        }




        


    }


    //Общие
    
    public void FreeDay(){
        g.QuestNow="FreeDay";
        string QuestTitle="Свободный день";
        string QuestText="Никаких проблем сегодня решать не надо, можно потратить время на себя";        
        Sprite ImageSprite = Resources.Load<Sprite>("Backgrounds/Rest   ");
        //Общее для всех вариантов
        
        byte AnswerCount = 2;
        byte b = 0;
        string[] DisionText = new string[AnswerCount];
        string[] DisionTip = new string[AnswerCount];
        string[] DisionReq = new string[AnswerCount];
        string[] DisionLead = new string[AnswerCount];

        DisionText[b]="Сыграть в теннис";
        DisionTip[b]="Полезно для здоровья";
        DisionReq[b]="(Требований нет)";
        DisionLead[b]="FreeTennis"; //к ивенту лег в больницу

        b+=1;
        DisionText[b]="Выпить";
        DisionTip[b]="Снимает стресс";
        DisionReq[b]="Не переусердствуйте (Требований нет)";
        DisionLead[b]="DrinkingCont"; //к ивенту лег в больницу


        //Собственно установка
        g.QuestTitle.GetComponent<Text>().text=QuestTitle;
        g.QuestText.GetComponent<Text>().text=QuestText;
        g.QuestImage.GetComponent<Image>().sprite=ImageSprite;
        
        //Проход по тоглам
        for(byte i=1;i<=6;i++)
        {
            //Debug.Log("Answer"+i.ToString());
            if(i<=AnswerCount) {
                Transform Ans;
                Ans = g.AnswerPanel.GetComponent<RectTransform>().Find("Answer"+i.ToString() );
                Ans.Find("AnswerText"+i.ToString()).GetComponent<Text>().text=DisionText[i-1];
                g.ResultDict.Add( ("Answer"+i.ToString()), DisionLead[i-1] ) ;
                g.AnswerPanel.GetComponent<RectTransform>().Find("Answer"+i.ToString()).gameObject.SetActive(true);
                g.TextRequires.GetComponent<Text>().text = DisionReq[i-1];
                g.TextTip.GetComponent<Text>().text = DisionTip[i-1];
                }
                
            else {
                g.AnswerPanel.GetComponent<RectTransform>().Find("Answer"+i.ToString()).gameObject.SetActive(false);
            }
            



        }




        


    }


}
