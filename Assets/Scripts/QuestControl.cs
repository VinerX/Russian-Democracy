using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuestControl : MonoBehaviour
{
    
    public void SetQuests(){

        
    }

    public void AddQuest(string Quest){
        if (!g.QuestGroup.Contains(Quest))
            g.QuestGroup.Add(Quest);
            g.QuestToSolve+=1;
            //g.Dan.BroadcastMessage(Quest);
        
    }
//g.Dan.DangerHp();


}
