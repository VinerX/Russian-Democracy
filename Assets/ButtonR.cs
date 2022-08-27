using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonR : MonoBehaviour
{
    public GameObject Buttons;
    // private void Start() {
    //     Buttons = GameObject.Find("Buttons");
    // }
    
    // Update is called once per frame
    void Update()
    {
        Debug.Log("RRR");
        if (Input.GetKeyDown(KeyCode.R))
        {
            Buttons.GetComponent<Buttons>().BroadcastMessage( "Finish");
            //g.Result.BroadcastMessage( NextQuest);
        }
    }
}
