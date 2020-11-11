using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chat : GAction
{
    public override bool PrePerform()
    {
        return true;
    }

    public override bool PostPerform()
    {
        DialogueManager.scc.setGameStateValue("chatting", "equals", "t");
        Debug.Log(DialogueManager.scc.getSCCLine("Nurse"));
        beliefs.RemoveState("soBored");
        return true;
    }
}
