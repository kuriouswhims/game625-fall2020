﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Patient : GAgent
{
    new void Start()
    {
        base.Start();
        SubGoal s1 = new SubGoal("isWaiting", 1, true);
        goals.Add(s1, 3);

        SubGoal s2 = new SubGoal("isTreated", 1, true);
        goals.Add(s2, 5);

        SubGoal s3 = new SubGoal("hasPaid", 1, true);
        goals.Add(s3, 5);

        SubGoal s4 = new SubGoal("isHome", 1, true);
        goals.Add(s4, 7);
    }
}
