using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Door : MonoBehaviour
{
  [SerializeField] private Date _date;
  public void Click(){
    _date.DataPlus();
    }
}