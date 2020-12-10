using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using UnityEngine;

public class Soap : CollectableItem
{


    public static event Action<Soap> OnSoapCollected;

    protected override void SetType()
    {
        objType = ObjectType.Soap;
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            if (OnSoapCollected != null)
            {
                OnSoapCollected(this);
            }
        }
    }
}