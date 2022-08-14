using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Functions : MonoBehaviour
{   
    //[SerializeField] private SetAllStat SaS; // SetAllS()

    public void SetGrafics(){
        g.hp_s.size = (float)g.hp[0]/100;
        g.popularity_s.size =(float)g.popularity[0]/100;
        g.stress_s.size = (float)g.stress[0]/100;
        g.drinking_s.size = (float)g.drinking[0]/100;
        g.polits_t.text = "Полит.Сила: "+g.polits[0].ToString();
        
    }

    public void SetChange(){
        g.hp[0]+=g.hp[1];
        if (g.hp[0]>100f) g.hp[0]=100f;
        if (g.hp[0]<25f) g.QC.AddQuest("DangerHp");
        g.stress[0]+=g.stress[1];
        g.drinking[0]+=g.drinking[1];
        if (g.drinking[0]>55f) g.QC.AddQuest("DangerDrinking");
        g.popularity[0]+=g.popularity[1];
        g.polits[0]+=g.polits[1];
        
    }



    public void ScreensOff(bool active) {
    foreach(GameObject El in g.ScreensTag) {
        El.SetActive(active);
        //Debug.Log(El.name);
    }
    }

    public void ToDeath(string Type){
        g.SaS.ScreensOff(false);
        g.DefeatMenu.SetActive(true);
        switch (Type)
        {
            case "hp":
                
                g.DefeatBg.GetComponent<Image>().sprite = Resources.Load<Sprite>("Backgrounds/Die");
                g.DefeatTextTitle.GetComponent<Text>().text = "Подвело здоровье...";
                g.DefeatText.GetComponent<Text>().text ="Постоянная работа(в том числе с документами), нагрузки, конфликты - все это не проходит следом..." +
                "Вот тело и не выдержало. Таким образом, первый президент России умер, и неизвестно, что ждет страну даже в ближайшем будущем. " 
                ; 
            break;
            
            case "popularity":
                
                g.DefeatBg.GetComponent<Image>().sprite = Resources.Load<Sprite>("Backgrounds/Doloy2");
                g.DefeatTextTitle.GetComponent<Text>().text = "Ультиматум";
                g.DefeatText.GetComponent<Text>().text ="У вас абсолютно нет поддержки. Вся страна желает вам смерти, и это в лучшем случае. Ваше окружание "+
                "намекнуло, что уходить надо именно сейчас, и желательно куда-нибудь в другую страну, так как шанс заговара или покушения максимально высок. "
                +"Вы были худшим правителем за всю историю страны...";
            break;
            
            case "stress":
                
                g.DefeatBg.GetComponent<Image>().sprite = Resources.Load<Sprite>("Backgrounds/stress");
                g.DefeatTextTitle.GetComponent<Text>().text = "Сердечный приступ";
                g.DefeatText.GetComponent<Text>().text ="Политика - дело грязное, и очень нервное." +
                "На вашу долю выпало слишком много трудностей - нервная система не справилась. Случился приступ." +
                "Похоже, такова участь президента демократической страны. Пора уходить в отставку"

                ; 
            break;

            case "drinking":
                
                g.DefeatBg.GetComponent<Image>().sprite = Resources.Load<Sprite>("Backgrounds/Drinking");
                g.DefeatTextTitle.GetComponent<Text>().text = "Спился";
                g.DefeatText.GetComponent<Text>().text ="Мятеж? Заговор? Переворот? Импичмент? Война? "+
                "Неизвестно, что прозошло, происходит или произойдет, все это за пределами вашего понимания"+
                "Одно хорошо - если вернетесь в сознание, вас примут в партию любителей пива."
                ;
            break;

        }   

    }


    public void CheckDef(){
        if (g.hp[0] <= 0f)
            ToDeath("hp");
        else if(g.popularity[0] <= 0f)
            ToDeath("popularity");
        else if(g.stress[0] >= 100f)
            ToDeath("stress");
        else if(g.drinking[0] >= 100f)
            ToDeath("drinking");



    }

    public void DataPlus()
    {
    g.Part += 1;
    if(g.Part > 4){
        g.Part = 1;
        g.Month += 1;
        if(g.Month > 12){
        g.Month = 1;
        g.Year += 1;
        }
    }
    g.DateText.text = g.Year + "." + g.Month + ".(" + g.Part + ").";
    }
    




}



