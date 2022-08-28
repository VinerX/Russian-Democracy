using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using UnityEngine.UI;



public class CountryCollapse : MonoBehaviour
{
    public static string CountryNow;

    // Мнение стран
    //public static dictionary<string,int> Opinion = new Dictionary<string,int>();
    public static Dictionary<string, int> Opinion = new Dictionary<string,int>()
    {
    
    {"Pribaltic",15},
    {"Belarus",55},
    {"Ukraine",40},
    {"Moldova",35},
    {"Kavkaz",50},
    {"Asia",75}
    };
    
    Color c;
    string t;
    private void OnMouseDown() {
        t=gameObject.name;
        //Debug.Log(t);
        
        ChoseCountryCollapse(t);
    }
    
    private void OnMouseEnter() {
        
        ColorUtility.TryParseHtmlString("#FF8600", out c);
        GetComponent<SpriteRenderer>().color=c;
    }
    private void OnMouseExit() {
        ColorUtility.TryParseHtmlString("#FFFF00", out c);
        GetComponent<SpriteRenderer>().color=c;
    }



    public void ChoseCountryCollapse(string Country){
        CountryNow = Country;

        //Какая это страна?
        switch (Country){
        case "Asia":
            g.ST.text = "Азия";
            break;
        case "Ukraine":
            g.ST.text = "Украина";
            break;
        case "Belarus":
            g.ST.text = "Беларусь";
            break;
        case "Kavkaz":
            g.ST.text = "Страны Кавказа";
            break;
        case "Pribaltic":
            g.ST.text = "Страны прибалтики";
            break;
        case "Moldova":
            g.ST.text = "Молдавия";
            break;
        
        default:
             g.ST.text=Country;
        break;
        }

        



    }

    public void GiveMoney(){
        if (!string.IsNullOrEmpty(CountryNow)){
        Opinion[CountryNow]+=5;
        GameObject.Find(CountryNow.ToString()+"Text").GetComponent<Text>().text = Opinion[CountryNow].ToString();
        //Ec.YearBalance-=5f;
        Ec.DisIncome+=5;
        //Ec.SetEcForStat();
        }
    }
}
