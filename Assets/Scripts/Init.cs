using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Init : MonoBehaviour
{
    

    public Scrollbar hp_s;
    public Scrollbar popularity_s;
    public Scrollbar stress_s;
    public Scrollbar drinking_s;
    
    


    void Start()
    {
    g.SaS.ScreensOff(false);
    g.Screens.GetComponent<Transform>().Find("MainGame").gameObject.SetActive(true);
    
    
    g.SaS.SetGrafics();
    }

  
}
