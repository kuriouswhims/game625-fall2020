using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoapObserved : SubjectBeingObserved
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            Notify(this, NotificationType.SoapCollected);
        }
        
    }

}
