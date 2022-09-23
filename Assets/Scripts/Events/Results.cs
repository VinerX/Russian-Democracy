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
        g.ResultNow = "MakeFederation";
        g.ResultTitle.GetComponent<Text>().text= "Новая Федерация";
        g.ResultText.GetComponent<Text>().text = "СССР "
        +" Конечно, государство будет уже не коммунистическое, но с теми же границами, что и у СССР";
        g.ResultImage.GetComponent<Image>().sprite = Resources.Load<Sprite>("EventImages/Union");
    }
    public void MakeConfederacy(){
        g.ResultNow = "MakeConfederacy";
        g.ResultTitle.GetComponent<Text>().text= "Союзу быть!";
        g.ResultText.GetComponent<Text>().text = "Российским дипломатам предстоит нереальная задача по сохранению союза и возвращению республик под его фактическую юрисдикцию."
        +" Конечно, государство будет уже не коммунистическое, но с теми же границами, что и у СССР";
        g.ResultImage.GetComponent<Image>().sprite = Resources.Load<Sprite>("EventImages/Union");
    }
    public void MakeSNG(){
        g.ResultNow = "MakeSNG";
        g.ResultTitle.GetComponent<Text>().text= "Новая реальность - СНГ";
        g.ResultText.GetComponent<Text>().text = "Союз уже не спасти, республики уже вкусили независимости. Нашим дипломатам следует заключить полезные договора, наладить единое экономическое пространство. "
        +" Также планируется создать Содружество Независимых Государств (СНГ)";
        g.ResultImage.GetComponent<Image>().sprite = Resources.Load<Sprite>("EventImages/Union");
    }
    public void OnlyRussia(){
        g.ResultNow = "OnlyRussia";
        g.ResultTitle.GetComponent<Text>().text= "Россия сама по себе";
        g.ResultText.GetComponent<Text>().text = "Российским дипломатам предстоит нереальная задача по сохранению союза и возвращению республик под его фактическую юрисдикцию."
        +" Конечно, государство будет уже не коммунистическое, но с теми же границами, что и у СССР";
        g.ResultImage.GetComponent<Image>().sprite = Resources.Load<Sprite>("EventImages/Union");
    }




    public void GKChP1(){
        g.ResultNow = "GKChP1";
        g.ResultTitle.GetComponent<Text>().text= "Путчисты";
        g.ResultText.GetComponent<Text>().text = "Вы позоботились, чтобы через некоторое время горе-бунтовщики были свободны";
        g.ResultImage.GetComponent<Image>().sprite = Resources.Load<Sprite>("Backgrounds/GKCHP");
    }

    public void GKChP2(){
        g.ResultNow = "GKChP2";
        g.ResultTitle.GetComponent<Text>().text= "Путчисты";
        g.ResultText.GetComponent<Text>().text = "Вы позоботились, чтобы через некоторое время горе-бунтовщики были свободны, но не участвовали в общественной деятельности";
        g.ResultImage.GetComponent<Image>().sprite = Resources.Load<Sprite>("Backgrounds/GKCHP");
    }
    public void GKChP3(){
        g.ResultNow = "GKChP3";
        g.ResultTitle.GetComponent<Text>().text= "Путчисты";
        g.ResultText.GetComponent<Text>().text = "Путчисты будут сидеть в тюрьме долго, по крайней мере пока не закончится вас срок...";
        g.ResultImage.GetComponent<Image>().sprite = Resources.Load<Sprite>("Backgrounds/GKCHP");
    }




    public void EndOfKPSS(){
        g.ResultNow = "EndOfKPSS";
        g.ResultTitle.GetComponent<Text>().text= "Конец КПСС";
        g.ResultText.GetComponent<Text>().text = "Вы издали указ о приостановке деятельности КПСС на территории РСФСР. Вскоре Парламент и прокуратура с ним ознакосятся.";
        g.ResultImage.GetComponent<Image>().sprite = Resources.Load<Sprite>("Backgrounds/GKCHP");
    }
    public void EndOfKPSS2(){
        g.ResultNow = "EndOfKPSS2";
        g.ResultTitle.GetComponent<Text>().text= "Конец КПСС";
        g.ResultText.GetComponent<Text>().text = "Вы издали указ о полном запрете деятельности КПСС на территории РСФСР. Вскоре Парламент и прокуратура с ним ознакосятся.";
        g.ResultImage.GetComponent<Image>().sprite = Resources.Load<Sprite>("Backgrounds/GKCHP");
    }


    public void Gorbachev1(){
        g.ResultNow = "Gorbachev1";
        g.ResultTitle.GetComponent<Text>().text= "Доеверие Горбачева";
        g.ResultText.GetComponent<Text>().text = "Несмотря на фактическую слабость Горбачева, вы заявили о продолжении сотрудничества с Горбачевым. Он положительно отозвался на вашу речь, а некоторые руководители республик даже счита.т, что теперь у союза больше шансов выжить. ";
        g.ResultImage.GetComponent<Image>().sprite = Resources.Load<Sprite>("Backgrounds/GKCHP");
       
    }
    public void Gorbachev2(){
        g.ResultNow = "Gorbachev2";
        g.ResultTitle.GetComponent<Text>().text= "Речь об оставке президента СССР";
        g.ResultText.GetComponent<Text>().text = "Уважаемый М.С.Горбачев! Обращаюсь к вам как к президенту СССР... Вы не справилсиь со своими обязанностями, экономика трещит, республики уходят... Требую вашей отставки с последующими выборами. ";
        g.ResultImage.GetComponent<Image>().sprite = Resources.Load<Sprite>("Backgrounds/GKCHP");
    }
    






}
