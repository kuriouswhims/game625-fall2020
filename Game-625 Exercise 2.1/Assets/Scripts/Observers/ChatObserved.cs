using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChatObserved : SubjectBeingObserved
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        Notify(this, NotificationType.ChatCollected);
    }

}
