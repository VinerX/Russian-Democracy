using UnityEngine;

public class ToGosStat : MonoBehaviour
{
    public GameObject GosStat;
    public void ToGosStatMenu(){
        
        g.SaS.ScreensOff(false);
        GosStat.SetActive(true);
        Ec.SetEcForStat();
        //g.SceneNow.SetActive(false);
    }





}
