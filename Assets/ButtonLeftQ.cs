using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonLeftQ : MonoBehaviour
{
    public GameObject Buttons;
    private void Start() {
        Buttons = GameObject.Find("Buttons");   
    } 
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q))
        {
            Buttons.GetComponent<Buttons>().BroadcastMessage( "LastQuest");
            //g.Result.BroadcastMessage( NextQuest);
        }
    }
}
