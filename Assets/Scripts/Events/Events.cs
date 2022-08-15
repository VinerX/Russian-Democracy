using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Events : MonoBehaviour
{

    // Реализовать можно 3 типа кнопок - кнопки простые, с условиями и скрытые по условиям

    //Блок предупредительных ивентов
    string[] DisionText = new string[6];
    string[] DisionTip = new string[6];
    string[] DisionReq = new string[6];
    bool[] DisionOn = {true,true,true,true,true,true};
    string[] DisionLead = new string[6];
    string QuestTitle;




    public void DangerHp(){
        g.QuestNow="DangerHp";
        QuestTitle="Угроза: Слабое здоровье";
        string QuestText="Доктора подняли тревогу. Ваше состояние критическое"+
        " - еще чуть-чуть, и тело откажет. Какие действия следует принять?";
        Sprite ImageSprite = Resources.Load<Sprite>("Backgrounds/stress");
        
        



        byte b = 0;
        DisionText[b]="Лечь в больницу";
        DisionTip[b]="Ваша политическая власть ослабнет, но здоровье вы поправите";
        DisionReq[b]="Соблюдать постельный режим. (Требований нет)";
        DisionLead[b]="HPHealing"; //к ивенту лег в больницу
 
        b+=1;
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
                Ans = g.Answer[i-1].GetComponent<Transform>();
                g.Answer[i-1].SetActive(true);
                Ans.Find("AnswerText"+i.ToString()).gameObject.GetComponent<Text>().text=DisionText[i-1];
                g.ResultDict.Add( ("Answer"+i.ToString()), DisionLead[i-1] ) ;
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
                g.Answer[i-1].SetActive(false);
            }
            



               
        
        
        
        }




        


    }
    public void DangerDrinking(){
        g.QuestNow="DangerDrinking";
        QuestTitle="Угроза: злоупотребление спиртным";
        string QuestText="Остановитесь. Хватит пить водку. Вы так долго не протянете";
        //" - еще чуть-чуть, и тело откажет. Какие действия следует принять?";
        Sprite ImageSprite = Resources.Load<Sprite>("Backgrounds/Drinking");
        
        



        byte b = 0;
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
                Ans = g.Answer[i-1].GetComponent<Transform>();
                g.Answer[i-1].SetActive(true);
                Ans.Find("AnswerText"+i.ToString()).gameObject.GetComponent<Text>().text=DisionText[i-1];
                g.ResultDict.Add( ("Answer"+i.ToString()), DisionLead[i-1] ) ;
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
                g.Answer[i-1].SetActive(false);
            }
            



               
        
        
        
        }




        


    }

    public void DangerPopularity(){
        g.QuestNow="DangerPopularity";
        QuestTitle="Угроза: непопулярность";
        string QuestText="Прогнозы неутешительные. Рейтинг идет к нулю, надо что-то менять";
        Sprite ImageSprite = Resources.Load<Sprite>("EventImages/Karik");
        
        



        byte b = 0;
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
                Ans = g.Answer[i-1].GetComponent<Transform>();
                g.Answer[i-1].SetActive(true);
                Ans.Find("AnswerText"+i.ToString()).gameObject.GetComponent<Text>().text=DisionText[i-1];
                g.ResultDict.Add( ("Answer"+i.ToString()), DisionLead[i-1] ) ;
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
                g.Answer[i-1].SetActive(false);
            }
            



               
        
        
        
        }




        


    }

    public void DangerStress(){
        g.QuestNow="DangerStress";
        QuestTitle="Угроза: постоянный стресс";
        string QuestText="Вам очень тяжело. Кажется, даже сердце начинает побаливать. Может что-то предпринять.";
        Sprite ImageSprite = Resources.Load<Sprite>("EventImages/Stress");
        
        



        byte b = 0;
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
                Ans = g.Answer[i-1].GetComponent<Transform>();
                g.Answer[i-1].SetActive(true);
                Ans.Find("AnswerText"+i.ToString()).gameObject.GetComponent<Text>().text=DisionText[i-1];
                g.ResultDict.Add( ("Answer"+i.ToString()), DisionLead[i-1] ) ;
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
                g.Answer[i-1].SetActive(false);
            }
            



               
        
        
        
        }




        


    }

    //Общие
    
    public void FreeDay(){
        g.QuestNow="FreeDay";
        QuestTitle="Свободный день";
        string QuestText="Никаких проблем сегодня решать не надо, можно потратить время на себя";        
        Sprite ImageSprite = Resources.Load<Sprite>("Backgrounds/Rest");
        //Общее для всех вариантов
        
        
        byte b = 0;
        

        DisionText[b]="Сыграть в теннис";
        DisionTip[b]="Полезно для здоровья";
        DisionReq[b]="(Требований нет)";
        DisionLead[b]="FreeTennis"; //к ивенту лег в больницу

        b+=1;
        DisionText[b]="Выпить";
        DisionTip[b]="Снимает стресс";
        DisionReq[b]="Не переусердствуйте (Требований нет)";
        DisionLead[b]="DrinkingCont"; //к ивенту лег в больницу
        // if (5>3) DisionOn[b]=false;

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
                Ans = g.Answer[i-1].GetComponent<Transform>();
                g.Answer[i-1].SetActive(true);
                Ans.Find("AnswerText"+i.ToString()).gameObject.GetComponent<Text>().text=DisionText[i-1];
                g.ResultDict.Add( ("Answer"+i.ToString()), DisionLead[i-1] ) ;
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
                g.Answer[i-1].SetActive(false);
            }
            



               
        
        
        
        }



        
        


    }











    // Ивенты в хрон порядке +-

    
    public void SovietCollapseStart(){
        g.QuestNow="SovietCollapseStart";
        QuestTitle="Союз трещит";
        string QuestText="ГКЧП заметно повлиял Ново-Огаревский процесс. Теперь республики требуют еще больше независимости, "
        +"еще больше привелегий, чтобы что-то подписать. Что в такой ситуации делать?";        
        Sprite ImageSprite = Resources.Load<Sprite>("EventImages/Special_Belovej");
        //Общее для всех вариантов
        
        
        byte b = 0;
        

        DisionText[b]="Нужно сохранить СССР... по крайней мере его границы";
        DisionTip[b]="";
        DisionReq[b]="Очень сложная задача. Нужны отношения 95 со всеми выбранными республиками";
        DisionLead[b]="SaveUnion"; 

        b+=1;
        DisionText[b]="Из республик должна получится неплохая федерация ССГ";
        DisionTip[b]="";
        DisionReq[b]="Задача средней сложности, нужно 75 отношений со всеми выбранными ресбуликами";
        DisionLead[b]="MakeFederation"; 
        
        b+=1;
        DisionText[b]="Конфедерация - наш компромисс с республиками ССГ";
        DisionTip[b]="";
        DisionReq[b]="Требуется 50 очков отношений с выбранными республиками";
        DisionLead[b]="MakeConfederacy"; 
        
        b+=1;
        DisionText[b]="Республики уже де-факто ушли. Создаем СНГ";
        DisionTip[b]="";
        DisionReq[b]="Требуется 25 очков отношений с выбранными республиками";
        DisionLead[b]="MakeSNG"; 
        
        b+=1;
        DisionText[b]="Никаких связей с Республиками, которые забрали все у России!";
        DisionTip[b]="Быстро завершает серию ивентов, Россия выходит из Союза.";
        DisionReq[b]="Решимость Русского Медведя (Требований нет)";
        DisionLead[b]="OnlyRussia"; 
        

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
                Ans = g.Answer[i-1].GetComponent<Transform>();
                g.Answer[i-1].SetActive(true);
                Ans.Find("AnswerText"+i.ToString()).gameObject.GetComponent<Text>().text=DisionText[i-1];
                g.ResultDict.Add( ("Answer"+i.ToString()), DisionLead[i-1] ) ;
                
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
                g.Answer[i-1].SetActive(false);
            }
            



               
        
        
        
        }



        
        


    }
















}
