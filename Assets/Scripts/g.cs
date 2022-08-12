using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public static class g
{

    //Подключить другие скрипты для функций
    public static Functions SaS = GameObject.Find("State").GetComponent<Functions>();





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

    //Поражение
    public static GameObject DefeatMenu = GameObject.Find("DefeatMenu");
    public static GameObject DefeatBg = GameObject.Find("DefeatBg");
    public static GameObject DefeatTextTitle = GameObject.Find("DefeatTextTitle");
    public static GameObject DefeatText = GameObject.Find("DefeatText");
    //Поражение

    public static Transform[] ScreensChild = Screens.GetComponentsInChildren<Transform>(true);
    public static GameObject[] ScreensTag = GameObject.FindGameObjectsWithTag("GameScreen");
    //new List<GameObject>();

   
   
}
