using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AchievmentSystem : MonoBehaviour, Observer
{

    public void OnNotify(object obj, NotificationType notificationType)
    {
        if (notificationType == NotificationType.CoffeeCollected)
        {
            Debug.Log("You're caffeinated!");
        }

        if (notificationType == NotificationType.SleepCollected)
        {
            Debug.Log("You're well rested!");
        }

        if (notificationType == NotificationType.ChatCollected)
        {
            Debug.Log("You're socialized!");
        }

        if (notificationType == NotificationType.SoapCollected)
        {
            Debug.Log("You're clean!");
        }

    }
    // Start is called before the first frame update
    void Start()
    {
        foreach (SubjectBeingObserved subject in GameObject.FindObjectsOfType<SubjectBeingObserved>())
        {
            subject.AddObserver(this);
        }
    }

}
