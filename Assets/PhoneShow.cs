using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PhoneShow : MonoBehaviour
{
    public static bool PanelActive=false;
    public GameObject Panel;
    void ShowPanel(){
        if (!PanelActive)
            Panel.SetActive(true);  
        else
            Panel.SetActive(false);
        PanelActive=!PanelActive;
    }
}
