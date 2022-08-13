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


    public void FreeTennis(){
        //Debug.Log("Результат");
        g.ResultNow = "FreeTennis";

        
        g.hp[0]+=3f;
        
        g.ResultTitle.GetComponent<Text>().text= "Хорошая игра в теннис";
        g.ResultText.GetComponent<Text>().text = "Увлекательно, а главное - полезно для здоровья";
        g.ResultImage.GetComponent<Image>().sprite = Resources.Load<Sprite>("Backgrounds/Drinking");
    }

    

    // public void NoneRes(){
    //     //Debug.Log("Результат");
    //     g.ResultNow = "DrinkingCont";
    //     g.drinking[0]+=5f;
    //     g.hp[0]-=2f;
    //     g.stress[0]-=10f;
    //     g.popularity[0]-=2f;
    //     g.ResultTitle.GetComponent<Text>().text= "Веселая неделя";
    //     g.ResultText.GetComponent<Text>().text = "Пили вы знатно, пили вы много...";
    //     g.ResultImage.GetComponent<Image>().sprite = Resources.Load<Sprite>("Backgrounds/Drinking");
    // }
}