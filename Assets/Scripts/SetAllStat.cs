using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SetAllStat : MonoBehaviour
{   
    //[SerializeField] private SetAllStat SaS; // SetAllS()
    public Scrollbar hp_s;
    public Scrollbar popilarity_s;
    public Scrollbar stress_s;
    public Scrollbar drinking_s;

    public void SetAllS(){
        hp_s.size = g.hp;
        popilarity_s.size = g.popularity;
        stress_s.size = g.stress;
        drinking_s.size = g.drinking;
    }
}
