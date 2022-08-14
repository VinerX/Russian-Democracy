using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OverToggle : MonoBehaviour
{


    private void Start() {
        
        for (byte i=1;i<=6;i++){
        GameObject t = GameObject.Find("Answer"+i.ToString());
        BoxCollider2D tc =t.GetComponent<BoxCollider2D>();
        RectTransform tt=t.GetComponent<RectTransform>();
        Vector2 tr=tt.rect.size;
        tc.size = tr;
        }
        
    //GameObject.Find("Answer1").GetComponent<BoxCollider2D>().size = GameObject.Find("Answer1").GetComponent<RectTransform>().size();
     }

    private void OnMouseOver() {
        string i = gameObject.name.Substring(6,1);
        int b= int.Parse(i)-1;
        g.TextTip.GetComponent<Text>().text=g.QuestTip[b];
        g.TextRequires.GetComponent<Text>().text=g.QuestReq[b];
                
        //g.QuestTip.text=;
    }
}
