using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class SoapCollectionNotifier : MonoBehaviour
{
    public static event Action<SoapCollectionNotifier> OnSoapCollected;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (OnSoapCollected != null)
        {
            OnSoapCollected(this);
        }
    }
    void Update()
    {

    }
}
