﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoffeeObserved : SubjectBeingObserved
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        Notify(this, NotificationType.CoffeeCollected);
    }

}