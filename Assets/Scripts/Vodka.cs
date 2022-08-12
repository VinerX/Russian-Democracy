using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Vodka : MonoBehaviour
{
    
    

    public void Click(){
        g.drinking[0] = g.drinking[0] + 1f;
        g.stress[0] = g.stress[0] - 1f;
        g.SaS.SetGrafics();
    }
}
