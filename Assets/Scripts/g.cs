using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public static class g
{

    //Подключить другие скрипты для функций
    public static Functions SaS = GameObject.Find("State").GetComponent<Functions>();
    public static Dangers Dan = GameObject.Find("DangersO").GetComponent<Dangers>();
    public static QuestControl QC = GameObject.Find("QuestControlO").GetComponent<QuestControl>();



    //Квестконтрол
    public static List<string> QuestGroup = new List<string>();
    public static string QuestNow = "FreeDay";
    public static int QuestToSolve = 0;
    public static List<string> SolvedQuests = new List<string>();
    //Квестконтрол


    //Статы
    // Если массив 1 - значение сейчас, 2 изменение за ход
    //Статы персонажа
    public static float[] hp = {25f,+1f};
    public static float[] popularity = {25f,0f};
    public static float[] stress = {25f,-1f};
    public static float[] drinking = {25f,-1f};
    //Конец стат персонажа

    // Объекты интерфейса
    public static Scrollbar hp_s = GameObject.Find("ScrollbarHp").GetComponent<Scrollbar>();
    public static Scrollbar popularity_s = GameObject.Find("ScrollbarPopularity2").GetComponent<Scrollbar>();
    public static Scrollbar stress_s = GameObject.Find("ScrollbarStress2").GetComponent<Scrollbar>();
    public static Scrollbar drinking_s = GameObject.Find("ScrollbarDrinking2").GetComponent<Scrollbar>();
    
    public static GameObject Screens = GameObject.Find("Screens");

    // Меню квеста
    public static GameObject QuestMenu = GameObject.Find("QuestMenu");

    public static GameObject QuestPanel = GameObject.Find("QuestPanel");
    public static GameObject QuestTitle = GameObject.Find("QuestTitle");
    public static GameObject QuestText = GameObject.Find("QuestText");
    public static GameObject QuestImage = GameObject.Find("QuestImage");


    public static GameObject AnswerPanel = GameObject.Find("AnswerPanel");
    //public static GameObject[] = g.AnswerPanel.GetComponent<RectTransform>().GetComponentsInChildren
    public static GameObject AnswerTitle = GameObject.Find("AnswerTitle");
    public static GameObject TextRequires = GameObject.Find("TextRequires");
    public static GameObject TextTip = GameObject.Find("TextTip");


     // Меню квеста
    
    
    
    
    // Меню поражения
    public static GameObject DefeatMenu = GameObject.Find("DefeatMenu");
    public static GameObject DefeatBg = GameObject.Find("DefeatBg");
    public static GameObject DefeatTextTitle = GameObject.Find("DefeatTextTitle");
    public static GameObject DefeatText = GameObject.Find("DefeatText");
    // Меню поражения

    public static Transform[] ScreensChild = Screens.GetComponentsInChildren<Transform>(true);
    public static GameObject[] ScreensTag = GameObject.FindGameObjectsWithTag("GameScreen");
    //new List<GameObject>();

   
   
}
