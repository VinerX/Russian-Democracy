using UnityEngine;
using UnityEngine.UI;


public class ToGosStat : MonoBehaviour
{
    public GameObject GosStat;
    public void ToGosStatMenu(){
        
        g.SaS.ScreensOff(false);
        GosStat.SetActive(true);
        Ec.SetEcForStat();

        
        GameObject.Find("Disincome").GetComponent<Text>().text="Расходы: "+ g.Econom["Disincome"][0].ToString();
        //g.SceneNow.SetActive(false);
    }





}
