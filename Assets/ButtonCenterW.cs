using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonCenterW : MonoBehaviour
{   
    public GameObject Buttons;
    private void Start() {
        Buttons = GameObject.Find("Buttons");
    }
    
    // Update is called once per frame
    void Update()
    {
        
        if (Input.GetKeyDown(KeyCode.W))
        {
            Buttons.GetComponent<Buttons>().BroadcastMessage( "ChangeQuest");
            // if (g.QuestMenuNow) 
            //     Buttons.GetComponent<Buttons>().BroadcastMessage( "ChangeQuest");
            // else 
            //     Buttons.GetComponent<Buttons>().BroadcastMessage( "ChangeQuest");
            
        }
    }
}
