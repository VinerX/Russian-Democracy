using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Door : MonoBehaviour
{
  [SerializeField] private Date _date;
  public void Click(){
    _date.DataPlus();
    
    g.hp[0]+=g.hp[1];
    g.popularity[0]+=g.popularity[1];
    g.stress[0]+=g.stress[1];
    g.drinking[0]+=g.drinking[1];
    g.SaS.SetChange();
    g.SaS.SetGrafics();
    g.SaS.CheckDef();
    }
}