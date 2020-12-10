using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class ItemCollectionNotifier : MonoBehaviour
{
    public static event Action<ItemCollectionNotifier> OnItemCollected;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (OnItemCollected != null)
        {
            OnItemCollected(this);
        }
    }
    void Update()
    {

    }
}
