using UnityEngine;
using UnityEngine.UI;


public class ToGosStat : MonoBehaviour
{
    public GameObject GosStat;
    public void ToGosStatMenu(){
        
        g.SaS.ScreensOff(false);
        GosStat.SetActive(true);
        Ec.SetEcForStat();

        GameObject.Find("StatIncome").GetComponent<Text>().text="Доходы: "+ Ec.Income.ToString();

        GameObject.Find("StatDisincome").GetComponent<Text>().text="Расходы: "+ Ec.DisIncome.ToString();
        Ec.Balance=Ec.Income-Ec.DisIncome;
        GameObject.Find("StatBalance").GetComponent<Text>().text="Баланс: "+ Ec.Balance.ToString();
        //g.SceneNow.SetActive(false);
    }





}
