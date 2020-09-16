using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class CollectableBoiNotifier : MonoBehaviour
{
    public static event Action<CollectableBoiNotifier> OnPinkBoiCollected;
    //public static event Action<CollectableBoiNotifier> OnBlooBoiCollected;
    //public static event Action<CollectableBoiNotifier> OnPurpleBoiCollected;


    private void OnTriggerEnter(Collider other)
    {
        if (OnPinkBoiCollected != null)
        {
            OnPinkBoiCollected(this);
        }

        /*if (OnBlooBoiCollected != null)
        {
            OnBlooBoiCollected(this);
        }

        if (OnPurpleBoiCollected != null)
        {
            OnPurpleBoiCollected(this);
        }*/
    }
}
