using UnityEngine;

public class ToGosStat : MonoBehaviour
{
    public GameObject GosStat;
    public void ToGosStatMenu(){
        
        g.SaS.ScreensOff(false);
        GosStat.SetActive(true);
        //g.SceneNow.SetActive(false);
    }
}
