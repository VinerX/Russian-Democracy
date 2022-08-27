using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToEconomStat : MonoBehaviour
{
    public GameObject EcStat;
    // Start is called before the first frame update

    void ToEcStat(){
        Ec.HideAllStat();
        EcStat.SetActive(true);
    }
}
