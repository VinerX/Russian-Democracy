using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonRightE : MonoBehaviour
{
    public GameObject Buttons;
    // private void Start() {
    //     Buttons = GameObject.Find("Buttons");
    // }
    
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            Debug.Log("EEEE");
            Buttons.GetComponent<Buttons>().BroadcastMessage( "NextQuest");
            //g.Result.BroadcastMessage( NextQuest);
        }
    }
}
