using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Init : MonoBehaviour
{
    [SerializeField] private SetAllStat SaS;
    [SerializeField] private Scrollbar hp_s;
    [SerializeField] private Scrollbar popularity_s;
    [SerializeField] private Scrollbar stress_s;
    [SerializeField] private Scrollbar drinking_s;



    void Start()
    {
    g.hp = 1f;
    g.popularity = 1f;
    g.stress = 0.5f;
    g.drinking = 0f;

    g.hp_s=hp_s;
    g.popularity_s=popularity_s;
    g.stress_s=stress_s ;
    g.drinking_s=drinking_s;



    SaS.SetAllS();
    }

  
}
