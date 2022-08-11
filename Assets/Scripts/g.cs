using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public static class g
{

    //Статы
    // Если массив 1 - значение сейчас, 2 изменение за ход


    //Статы персонажа
    public static int[] hp = {25,-1};
    public static int[] popularity = {25,-1};
    public static int[] stress = {25,-1};
    public static int[] drinking = {25,+1};
    //Конец стат персонажа

    // Объекты интерфейса
    public static Scrollbar hp_s = GameObject.Find("ScrollbarHp").GetComponent<Scrollbar>();
    public static Scrollbar popularity_s = GameObject.Find("ScrollbarPopularity2").GetComponent<Scrollbar>();
    public static Scrollbar stress_s = GameObject.Find("ScrollbarStress2").GetComponent<Scrollbar>();
    public static Scrollbar drinking_s = GameObject.Find("ScrollbarDrinking2").GetComponent<Scrollbar>();
    
    public static GameObject Screens = GameObject.Find("Screens");
    public static Functions SaS = GameObject.Find("State").GetComponent<Functions>();
    public static Transform[] ScreensChild = Screens.GetComponentsInChildren<Transform>(true);
    public static GameObject[] ScreensTag = GameObject.FindGameObjectsWithTag("GameScreen");
    //new List<GameObject>();

   
   
}
