using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Vodka : MonoBehaviour
{
    
    public void Click(){
        g.drinking = g.drinking + 0.01f;
        g.stress = g.stress - 0.01f;
        g.drinking_s.size = g.drinking;
        g.stress_s.size = g.stress;
    }
}
