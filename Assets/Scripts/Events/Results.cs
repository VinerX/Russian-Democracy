using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Results : MonoBehaviour
{
    public void HPHealing(){
        //Debug.Log("Результат");
        g.ResultNow = "HPHealing";
        g.hp[0]+=3f;
        g.ResultTitle.GetComponent<Text>().text= "Больничный";
        g.ResultText.GetComponent<Text>().text = "Неделя в больнице поправила вам здоровье";
        g.ResultImage.GetComponent<Image>().sprite = Resources.Load<Sprite>("Menus/MainGame/Yeltsin");
    }

    public void HPCure(){
        //Debug.Log("Результат");
        g.ResultNow = "HPCure";
        g.hp[0]+=1f;
        g.ResultTitle.GetComponent<Text>().text= "Таблеточки";
        g.ResultText.GetComponent<Text>().text = "Не больница, но тоже не плохо";
        g.ResultImage.GetComponent<Image>().sprite = Resources.Load<Sprite>("Menus/MainGame/Yeltsin");
    }

    public void DrinkingStop(){
        //Debug.Log("Результат");
        g.ResultNow = "DrinkingStop";
        g.drinking[0]-=5f;
        g.stress[0]+=2f;
        g.ResultTitle.GetComponent<Text>().text= "Неделя без алкоголя";
        g.ResultText.GetComponent<Text>().text = "Тяжело, но необходимо";
        g.ResultImage.GetComponent<Image>().sprite = Resources.Load<Sprite>("Backgrounds/Drinking");
    }
    public void DrinkingCont(){
        //Debug.Log("Результат");
        g.ResultNow = "DrinkingCont";
        g.drinking[0]+=5f;
        g.hp[0]-=2f;
        g.stress[0]-=10f;
        g.popularity[0]-=2f;
        g.ResultTitle.GetComponent<Text>().text= "Веселая неделя";
        g.ResultText.GetComponent<Text>().text = "Пили вы знатно, пили вы много...";
        g.ResultImage.GetComponent<Image>().sprite = Resources.Load<Sprite>("Backgrounds/Drinking");
    }
    public void PopularityTV(){
        //Debug.Log("Результат");
        g.ResultNow = "PopularityTV";
        g.popularity[0]+=3f;
        g.ResultTitle.GetComponent<Text>().text= "Показ по тв";
        g.ResultText.GetComponent<Text>().text = "Так и быть, на кого-то это подействовало";
        g.ResultImage.GetComponent<Image>().sprite = Resources.Load<Sprite>("EventImages/Speach");
    }


    public void FreeTennis(){
        //Debug.Log("Результат");
        g.ResultNow = "FreeTennis";

        
        g.hp[0]+=3f;
        
        g.ResultTitle.GetComponent<Text>().text= "Хорошая игра в теннис";
        g.ResultText.GetComponent<Text>().text = "Увлекательно, а главное - полезно для здоровья";
        g.ResultImage.GetComponent<Image>().sprite = Resources.Load<Sprite>("EventImages/Tennis");
    }

    

    public void NoneRes(){
        g.ResultNow = "None";
        g.ResultTitle.GetComponent<Text>().text= "Ничего не произошло";
        g.ResultText.GetComponent<Text>().text = "Хоть вы и президент, но такое все-равно случается. Неделя прошла вообще без проишествий. Но скучно.";
        g.ResultImage.GetComponent<Image>().sprite = Resources.Load<Sprite>("EventImages/FunnyYeltsin");
    }

















    // Резы ивентов
    public void SaveUnion(){
        g.ResultNow = "SaveUnion";
        g.ResultTitle.GetComponent<Text>().text= "Союзу быть!";
        g.ResultText.GetComponent<Text>().text = "Российским дипломатам предстоит нереальная задача по сохранению союза и возвращению республик под его фактическую юрисдикцию."
        +" Конечно, государство будет уже не коммунистическое, но с теми же границами, что и у СССР";
        g.ResultImage.GetComponent<Image>().sprite = Resources.Load<Sprite>("EventImages/Union");
    }
    public void MakeFederation(){
        g.ResultNow = "SaveUnion";
        g.ResultTitle.GetComponent<Text>().text= "Союзу быть!";
        g.ResultText.GetComponent<Text>().text = "Российским дипломатам предстоит нереальная задача по сохранению союза и возвращению республик под его фактическую юрисдикцию."
        +" Конечно, государство будет уже не коммунистическое, но с теми же границами, что и у СССР";
        g.ResultImage.GetComponent<Image>().sprite = Resources.Load<Sprite>("EventImages/Union");
    }
    public void MakeConfederacy(){
        g.ResultNow = "SaveUnion";
        g.ResultTitle.GetComponent<Text>().text= "Союзу быть!";
        g.ResultText.GetComponent<Text>().text = "Российским дипломатам предстоит нереальная задача по сохранению союза и возвращению республик под его фактическую юрисдикцию."
        +" Конечно, государство будет уже не коммунистическое, но с теми же границами, что и у СССР";
        g.ResultImage.GetComponent<Image>().sprite = Resources.Load<Sprite>("EventImages/Union");
    }
    public void MakeSNG(){
        g.ResultNow = "SaveUnion";
        g.ResultTitle.GetComponent<Text>().text= "Союзу быть!";
        g.ResultText.GetComponent<Text>().text = "Российским дипломатам предстоит нереальная задача по сохранению союза и возвращению республик под его фактическую юрисдикцию."
        +" Конечно, государство будет уже не коммунистическое, но с теми же границами, что и у СССР";
        g.ResultImage.GetComponent<Image>().sprite = Resources.Load<Sprite>("EventImages/Union");
    }
    public void OnlyRussia(){
        g.ResultNow = "SaveUnion";
        g.ResultTitle.GetComponent<Text>().text= "Союзу быть!";
        g.ResultText.GetComponent<Text>().text = "Российским дипломатам предстоит нереальная задача по сохранению союза и возвращению республик под его фактическую юрисдикцию."
        +" Конечно, государство будет уже не коммунистическое, но с теми же границами, что и у СССР";
        g.ResultImage.GetComponent<Image>().sprite = Resources.Load<Sprite>("EventImages/Union");
    }

















}
