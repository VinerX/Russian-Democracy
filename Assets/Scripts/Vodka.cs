using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Vodka : MonoBehaviour
{
    
    

    public void Click(){
        g.drinking[0] = g.drinking[0] + 1;
        g.stress[0] = g.stress[0] - 1;
        //g.drinking_s.size = (float)g.drinking[0]/100;
        //g.stress_s.size = (float)g.stress[0]/100;
        //Debug.Log("+Питье");
        g.SaS.SetAllS();
        g.SaS.SetG();
    }
}
