using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NextResR : MonoBehaviour
{
    public GameObject Buttons;
    
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            Buttons.GetComponent<Buttons>().BroadcastMessage( "NextResult");
            //g.Result.BroadcastMessage( NextQuest);
        }
    }
}
