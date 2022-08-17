using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StatTextAdd : MonoBehaviour
{
    
    void OnActive()
    {
        g.Stats.Add(gameObject);
    }

}
