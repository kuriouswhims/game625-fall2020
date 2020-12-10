using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class CoffeeCollectionNotifier : MonoBehaviour
{
    public static event Action<CoffeeCollectionNotifier> OnCoffeeCollected;

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
