using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddEc : MonoBehaviour
{
    public GameObject G;
    List<GameObject> g= new List<GameObject>();
    public void CopyG(){
        g.Add(Instantiate(G));
        //g[-1].;
    }
    
}
