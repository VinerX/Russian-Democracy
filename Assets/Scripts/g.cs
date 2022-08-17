using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public static class g
{

    //Подключить другие скрипты для функций
    public static Functions SaS = GameObject.Find("State").GetComponent<Functions>();
    public static Events Event = GameObject.Find("EventsO").GetComponent<Events>();
    public static Init Init = GameObject.Find("InitO").GetComponent<Init>();
    public static QuestControl QC = GameObject.Find("QuestControlO").GetComponent<QuestControl>();
    



    //Квестконтрол
    public static List<string> QuestGroup = new List<string>();
    
    
    
    public static List<string> SolvedQuests = new List<string>();
    //Квестконтрол


    //Статы
    // Если массив 1 - значение сейчас, 2 изменение за ход
    
    
    
    //Статы персонажа
    public static float[] polits = {50f,+1f};
    public static float[] hp = {25f,+1f};
    public static float[] popularity = {25f,0f};
    public static float[] stress = {25f,-1f};
    public static float[] drinking = {25f,-1f};
    //Конец стат персонажа

    // Объекты интерфейса

    // Графика персонажа
    public static Scrollbar hp_s = GameObject.Find("ScrollbarHp").GetComponent<Scrollbar>();
    public static Scrollbar popularity_s = GameObject.Find("ScrollbarPopularity2").GetComponent<Scrollbar>();
    public static Scrollbar stress_s = GameObject.Find("ScrollbarStress2").GetComponent<Scrollbar>();
    public static Scrollbar drinking_s = GameObject.Find("ScrollbarDrinking2").GetComponent<Scrollbar>();
    public static Text polits_t = GameObject.Find("Polit").GetComponent<Text>();
    
    public static GameObject Screens = GameObject.Find("Screens");
    //
    public static Text ST = GameObject.Find("StateName").GetComponent<Text>();

    //Даты 
    public static int Year = 1991;
    public static int Month = 8;
    public static int Part = 4;
    public static string DateAll="1991.8.(4)";
    public static Text DateText = GameObject.Find("Date").GetComponent<Text>();

    // Дата - добавление ивента
    public static Dictionary<string,string> DateEvent= new Dictionary<string,string>{
    {"1991.9.(1)","SovietCollapseStart"}

    };


    //Общее по интерфейсу
    public static Scene SceneNow;


    // Меню квеста
    public static GameObject QuestMenu = GameObject.Find("QuestMenu");
    public static string QuestNow = "FreeDay";
    public static int QuestToSolve = 0;
    public static GameObject QuestPanel = GameObject.Find("QuestPanel");
    public static GameObject QuestTitle = GameObject.Find("QuestTitle");
    public static GameObject QuestText = GameObject.Find("QuestText");
    public static GameObject QuestImage = GameObject.Find("QuestImage");
    public static GameObject QuestCount = GameObject.Find("QuestCount");
    public static GameObject QuestSoldText = GameObject.Find("QuestSoldText");
    public static string[] QuestReq = new string[6];
    public static string[] QuestTip = new string[6];
    public static bool[] QuestOn = {true,true,true,true,true,true};
    public static bool QuestMenuNow = true;

    //Панель ответа
    public static GameObject AnswerPanel = GameObject.Find("AnswerPanel");
    public static GameObject[] Answer = {
    GameObject.Find("Answer1"),
    GameObject.Find("Answer2"),
    GameObject.Find("Answer3"),
    GameObject.Find("Answer4"),
    GameObject.Find("Answer5"),
    GameObject.Find("Answer6")};
    public static GameObject AnswerTitle = GameObject.Find("AnswerTitle");
    public static GameObject TextRequires = GameObject.Find("TextRequires");
    public static GameObject TextTip = GameObject.Find("TextTip");
    

    //Меню результата
    public static Dictionary<string,string> ResultDict = new Dictionary<string,string>();
    public static Results Result = GameObject.Find("ResultsO").GetComponent<Results>();
    public static string ResultNow;
    public static int Results = 0;
    public static List<string> ResultGroup = new List<string>();
    public static string[] ResultFor1 = new string[50];
    public static int[] ResultNFor1 = new int[50];
    public static GameObject ResultPanel = GameObject.Find("ResultPanel");
    public static GameObject ResultTitle = GameObject.Find("ResultlTitle");
    public static GameObject ResultText = GameObject.Find("ResultText");
    public static GameObject ResultImage = GameObject.Find("ResultImage");
      
    
    
    // Меню поражения
    public static GameObject DefeatMenu = GameObject.Find("DefeatMenu");
    public static GameObject DefeatBg = GameObject.Find("DefeatBg");
    public static GameObject DefeatTextTitle = GameObject.Find("DefeatTextTitle");
    public static GameObject DefeatText = GameObject.Find("DefeatText");
    // Меню поражения

    public static Transform[] ScreensChild = Screens.GetComponentsInChildren<Transform>(true);
    public static GameObject[] ScreensTag = GameObject.FindGameObjectsWithTag("GameScreen");
    //new List<GameObject>();

   



    // Ивент - крушение союза
    










}
