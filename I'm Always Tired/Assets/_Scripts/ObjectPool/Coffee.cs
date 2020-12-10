using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using UnityEngine;

public class Coffee : CollectableItem
{


    public static event Action<Coffee> OnCoffeeCollected;

    protected override void SetType()
    {
        objType = ObjectType.Coffee;
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            if (OnCoffeeCollected != null)
            {
                OnCoffeeCollected(this);
            }
        }
    }
}