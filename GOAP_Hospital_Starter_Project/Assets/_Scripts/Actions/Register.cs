using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Register : GAction
{
    public override bool PrePerform()
    {
        return true;
    }

    public override bool PostPerform()
    {
        Debug.Log(DialogueManager.scc.getSCCLine("Patient"));
        return true;
    }
}
