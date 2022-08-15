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
        
        string[] DisionText = new string[6];
        string[] DisionTip = new string[6];
        string[] DisionReq = new string[6];
        bool[] DisionOn = {true,true,true,true,true,true};
        string[] DisionLead = new string[6];



        byte b =0;
        DisionText[b]="Лечь в больницу";
        DisionTip[b]="Ваша политическая власть ослабнет, но здоровье вы поправите";
        DisionReq[b]="Соблюдать постельный режим. (Требований нет)";
        DisionLead[b]="HPHealing"; //к ивенту лег в больницу
 
        b +=1;
        DisionText[b]="Принять таблетки";
        DisionTip[b]="Немного поправит здоровье";
        DisionReq[b]="Запивать водой (Требований нет)";
        DisionLead[b]="HPCure"; //к ивенту лег в больницу

        b+=1;
        DisionText[b]="Ничего не делать";
        DisionTip[b]="";
        DisionReq[b]="";
        DisionLead[b]="None"; 

        //Собственно установка
        g.QuestTitle.GetComponent<Text>().text=QuestTitle;
        g.AnswerTitle.GetComponent<Text>().text=QuestTitle;
        g.QuestText.GetComponent<Text>().text=QuestText;
        g.QuestImage.GetComponent<Image>().sprite=ImageSprite;
        

        
        
        b+=1;
        //Проход по тоглам
       for(byte i=1;i<=6;i++)
        {
            //Debug.Log("Answer"+i.ToString());
            if(i<=b) {
                Transform Ans;
                Ans = g.AnswerPanel.GetComponent<RectTransform>().Find("Answer"+i.ToString() );
                Ans.Find("AnswerText"+i.ToString()).GetComponent<Text>().text=DisionText[i-1];
                g.ResultDict.Add( ("Answer"+i.ToString()), DisionLead[i-1] ) ;
                g.AnswerPanel.GetComponent<RectTransform>().Find("Answer"+i.ToString()).gameObject.SetActive(true);
                g.QuestTip[i-1]=DisionTip[i-1];
                g.QuestReq[i-1]=DisionReq[i-1];
                g.QuestOn[i-1]=DisionOn[i-1];
                if (DisionOn[i-1]==false) {
                    
                    Ans.gameObject.GetComponent<Toggle>().transition=Selectable.Transition.None;
                    Ans.Find("AnswerTogle"+i.ToString()).gameObject.GetComponent<Image>().sprite= Resources.Load<Sprite>("Choice4");
                    Ans.gameObject.GetComponent<Toggle>().interactable=false;


                    }
                else {
                    Ans.gameObject.GetComponent<Toggle>().transition=Selectable.Transition.SpriteSwap;
                    Ans.Find("AnswerTogle"+i.ToString()).gameObject.GetComponent<Image>().sprite= Resources.Load<Sprite>("Choice1");
                    Ans.gameObject.GetComponent<Toggle>().interactable=true;


                }

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
        
        string[] DisionText = new string[6];
        string[] DisionTip = new string[6];
        string[] DisionReq = new string[6];
        bool[] DisionOn = {true,true,true,true,true,true};
        string[] DisionLead = new string[6];



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

        b+=1;
        DisionText[b]="Ничего не делать";
        DisionTip[b]="";
        DisionReq[b]="";
        DisionLead[b]="None"; 

        //Собственно установка
        g.QuestTitle.GetComponent<Text>().text=QuestTitle;
        g.AnswerTitle.GetComponent<Text>().text=QuestTitle;
        g.QuestText.GetComponent<Text>().text=QuestText;
        g.QuestImage.GetComponent<Image>().sprite=ImageSprite;


        
        b+=1;
        //Проход по тоглам
        for(byte i=1;i<=6;i++)
        {
            //Debug.Log("Answer"+i.ToString());
            if(i<=b) {
                Transform Ans;
                Ans = g.AnswerPanel.GetComponent<RectTransform>().Find("Answer"+i.ToString() );
                Ans.Find("AnswerText"+i.ToString()).GetComponent<Text>().text=DisionText[i-1];
                g.ResultDict.Add( ("Answer"+i.ToString()), DisionLead[i-1] ) ;
                g.AnswerPanel.GetComponent<RectTransform>().Find("Answer"+i.ToString()).gameObject.SetActive(true);
                g.QuestTip[i-1]=DisionTip[i-1];
                g.QuestReq[i-1]=DisionReq[i-1];
                g.QuestOn[i-1]=DisionOn[i-1];
                if (DisionOn[i-1]==false) {
                    
                    Ans.gameObject.GetComponent<Toggle>().transition=Selectable.Transition.None;
                    Ans.Find("AnswerTogle"+i.ToString()).gameObject.GetComponent<Image>().sprite= Resources.Load<Sprite>("Choice4");
                    Ans.gameObject.GetComponent<Toggle>().interactable=false;


                    }
                else {
                    Ans.gameObject.GetComponent<Toggle>().transition=Selectable.Transition.SpriteSwap;
                    Ans.Find("AnswerTogle"+i.ToString()).gameObject.GetComponent<Image>().sprite= Resources.Load<Sprite>("Choice1");
                    Ans.gameObject.GetComponent<Toggle>().interactable=true;


                }

                    }


            else {
                g.AnswerPanel.GetComponent<RectTransform>().Find("Answer"+i.ToString()).gameObject.SetActive(false);
            }
            



               
        
        
        
        }




        


    }

    public void DangerPopularity(){
        g.QuestNow="DangerPopularity";
        string QuestTitle="Угроза: непопулярность";
        string QuestText="Прогнозы неутешительные. Рейтинг идет к нулю, надо что-то менять";
        Sprite ImageSprite = Resources.Load<Sprite>("EventImages/Karik");
        
        string[] DisionText = new string[6];
        string[] DisionTip = new string[6];
        string[] DisionReq = new string[6];
        bool[] DisionOn = {true,true,true,true,true,true};
        string[] DisionLead = new string[6];



        byte b =0;
        DisionText[b]="Заплатим телевидению ";
        DisionTip[b]="-бюджет администрации президента, +популярность";
        DisionReq[b]="(Требований нет)";
        DisionLead[b]="PopularityTV"; 

        b+=1;
        DisionText[b]="Ничего не делать";
        DisionTip[b]="";
        DisionReq[b]="";
        DisionLead[b]="None"; 



        //Собственно установка
        g.QuestTitle.GetComponent<Text>().text=QuestTitle;
        g.AnswerTitle.GetComponent<Text>().text=QuestTitle;
        g.QuestText.GetComponent<Text>().text=QuestText;
        g.QuestImage.GetComponent<Image>().sprite=ImageSprite;


        
        b+=1;
        //Проход по тоглам
        for(byte i=1;i<=6;i++)
        {
            //Debug.Log("Answer"+i.ToString());
            if(i<=b) {
                Transform Ans;
                Ans = g.AnswerPanel.GetComponent<RectTransform>().Find("Answer"+i.ToString() );
                Ans.Find("AnswerText"+i.ToString()).GetComponent<Text>().text=DisionText[i-1];
                g.ResultDict.Add( ("Answer"+i.ToString()), DisionLead[i-1] ) ;
                g.AnswerPanel.GetComponent<RectTransform>().Find("Answer"+i.ToString()).gameObject.SetActive(true);
                g.QuestTip[i-1]=DisionTip[i-1];
                g.QuestReq[i-1]=DisionReq[i-1];
                g.QuestOn[i-1]=DisionOn[i-1];
                if (DisionOn[i-1]==false) {
                    
                    Ans.gameObject.GetComponent<Toggle>().transition=Selectable.Transition.None;
                    Ans.Find("AnswerTogle"+i.ToString()).gameObject.GetComponent<Image>().sprite= Resources.Load<Sprite>("Choice4");
                    Ans.gameObject.GetComponent<Toggle>().interactable=false;


                    }
                else {
                    Ans.gameObject.GetComponent<Toggle>().transition=Selectable.Transition.SpriteSwap;
                    Ans.Find("AnswerTogle"+i.ToString()).gameObject.GetComponent<Image>().sprite= Resources.Load<Sprite>("Choice1");
                    Ans.gameObject.GetComponent<Toggle>().interactable=true;


                }

                    }


            else {
                g.AnswerPanel.GetComponent<RectTransform>().Find("Answer"+i.ToString()).gameObject.SetActive(false);
            }
            



               
        
        
        
        }




        


    }

    public void DangerStress(){
        g.QuestNow="DangerStress";
        string QuestTitle="Угроза: постоянный стресс";
        string QuestText="Вам очень тяжело. Кажется, даже сердце начинает побаливать. Может что-то предпринять.";
        Sprite ImageSprite = Resources.Load<Sprite>("EventImages/Stress");
        
        string[] DisionText = new string[6];
        string[] DisionTip = new string[6];
        string[] DisionReq = new string[6];
        bool[] DisionOn = {true,true,true,true,true,true};
        string[] DisionLead = new string[6];



        byte b =0;
        DisionText[b]="Рюмочку!";
        DisionTip[b]="-Стресс, -Здоровье, +Алкоголизм";
        DisionReq[b]="(Требований нет)";
        DisionLead[b]="DrinkingCont"; 

        b+=1;
        DisionText[b]="Ничего не делать";
        DisionTip[b]="";
        DisionReq[b]="";
        DisionLead[b]="None"; 



        //Собственно установка
        g.QuestTitle.GetComponent<Text>().text=QuestTitle;
        g.AnswerTitle.GetComponent<Text>().text=QuestTitle;
        g.AnswerTitle.GetComponent<Text>().text=QuestTitle;
        g.QuestText.GetComponent<Text>().text=QuestText;
        g.QuestImage.GetComponent<Image>().sprite=ImageSprite;
        


        
        b+=1;
        //Проход по тоглам
        for(byte i=1;i<=6;i++)
        {
            //Debug.Log("Answer"+i.ToString());
            if(i<=b) {
                Transform Ans;
                Ans = g.AnswerPanel.GetComponent<RectTransform>().Find("Answer"+i.ToString() );
                Ans.Find("AnswerText"+i.ToString()).GetComponent<Text>().text=DisionText[i-1];
                g.ResultDict.Add( ("Answer"+i.ToString()), DisionLead[i-1] ) ;
                g.AnswerPanel.GetComponent<RectTransform>().Find("Answer"+i.ToString()).gameObject.SetActive(true);
                g.QuestTip[i-1]=DisionTip[i-1];
                g.QuestReq[i-1]=DisionReq[i-1];
                g.QuestOn[i-1]=DisionOn[i-1];
                if (DisionOn[i-1]==false) {
                    
                    Ans.gameObject.GetComponent<Toggle>().transition=Selectable.Transition.None;
                    Ans.Find("AnswerTogle"+i.ToString()).gameObject.GetComponent<Image>().sprite= Resources.Load<Sprite>("Choice4");
                    Ans.gameObject.GetComponent<Toggle>().interactable=false;


                    }
                else {
                    Ans.gameObject.GetComponent<Toggle>().transition=Selectable.Transition.SpriteSwap;
                    Ans.Find("AnswerTogle"+i.ToString()).gameObject.GetComponent<Image>().sprite= Resources.Load<Sprite>("Choice1");
                    Ans.gameObject.GetComponent<Toggle>().interactable=true;


                }

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
        Sprite ImageSprite = Resources.Load<Sprite>("Backgrounds/Rest");
        //Общее для всех вариантов
        
        
        byte b = 0;
        string[] DisionText = new string[6];
        string[] DisionTip = new string[6];
        string[] DisionReq = new string[6];
        bool[] DisionOn = {true,true,true,true,true,true};
        string[] DisionLead = new string[6];

        DisionText[b]="Сыграть в теннис";
        DisionTip[b]="Полезно для здоровья";
        DisionReq[b]="(Требований нет)";
        DisionLead[b]="FreeTennis"; //к ивенту лег в больницу

        b+=1;
        DisionText[b]="Выпить";
        DisionTip[b]="Снимает стресс";
        DisionReq[b]="Не переусердствуйте (Требований нет)";
        DisionLead[b]="DrinkingCont"; //к ивенту лег в больницу
        if (5>3) DisionOn[b]=false;

        //Собственно установка
        g.QuestTitle.GetComponent<Text>().text=QuestTitle;
        g.AnswerTitle.GetComponent<Text>().text=QuestTitle;
        g.QuestText.GetComponent<Text>().text=QuestText;
        g.QuestImage.GetComponent<Image>().sprite=ImageSprite;
        
        b+=1;
        //Проход по тоглам
        
        for(byte i=1;i<=6;i++)
        {
            //Debug.Log("Answer"+i.ToString());
            if(i<=b) {
                Transform Ans;
                Ans = g.AnswerPanel.GetComponent<RectTransform>().Find("Answer"+i.ToString() );
                Ans.Find("AnswerText"+i.ToString()).GetComponent<Text>().text=DisionText[i-1];
                g.ResultDict.Add( ("Answer"+i.ToString()), DisionLead[i-1] ) ;
                g.AnswerPanel.GetComponent<RectTransform>().Find("Answer"+i.ToString()).gameObject.SetActive(true);
                g.QuestTip[i-1]=DisionTip[i-1];
                g.QuestReq[i-1]=DisionReq[i-1];
                g.QuestOn[i-1]=DisionOn[i-1];
                if (DisionOn[i-1]==false) {
                    
                    Ans.gameObject.GetComponent<Toggle>().transition=Selectable.Transition.None;
                    Ans.Find("AnswerTogle"+i.ToString()).gameObject.GetComponent<Image>().sprite= Resources.Load<Sprite>("Choice4");
                    Ans.gameObject.GetComponent<Toggle>().interactable=false;


                    }
                else {
                    Ans.gameObject.GetComponent<Toggle>().transition=Selectable.Transition.SpriteSwap;
                    Ans.Find("AnswerTogle"+i.ToString()).gameObject.GetComponent<Image>().sprite= Resources.Load<Sprite>("Choice1");
                    Ans.gameObject.GetComponent<Toggle>().interactable=true;


                }

                    }


            else {
                g.AnswerPanel.GetComponent<RectTransform>().Find("Answer"+i.ToString()).gameObject.SetActive(false);
            }
            



               
        
        
        
        }



        
        


    }

    
}
