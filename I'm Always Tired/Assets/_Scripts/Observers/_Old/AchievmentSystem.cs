using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AchievmentSystem : MonoBehaviour, Observer
{

    public void OnNotify(object obj, NotificationType notificationType)
    {
        if (notificationType == NotificationType.CoffeeCollected)
        {
            speedBoost();
            Debug.Log("You're caffeinated!");
        }

        if (notificationType == NotificationType.SleepCollected)
        {
            sleepPickUp();
            Debug.Log("You're well rested!");
        }

        if (notificationType == NotificationType.ChatCollected)
        {
            pickUpObject();
            Debug.Log("You're socialized!");
        }

        if (notificationType == NotificationType.SoapCollected)
        {
            pickUpObject();
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

    public void pickUpObject()
    {
        Debug.Log("item picked up");
            //Destroy(other.gameObject);
            /*healthBarImage.fillAmount += 1f;
            healthBarImage.fillAmount = health / maxHealth;
            audioSource.PlayOneShot(collectSound, 1F);
            health += 10f;*/
    }

    public void speedBoost()
    {
        Debug.Log("speedboost");
            //Destroy(other.gameObject);
            /*healthBarImage.fillAmount += 1f;
            healthBarImage.fillAmount = health / maxHealth;
            audioSource.PlayOneShot(collectSound, 1F);
            health -= 5f;
            runTimer = 10f;
            Debug.Log("Fast");*/
    }

    public void sleepPickUp()
    {
        Debug.Log("sleep time");
        //Destroy(gameObject);
        //healthBarImage.fillAmount += 1f;
        //healthBarImage.fillAmount = health / maxHealth;
        //audioSource.PlayOneShot(collectSound, 1F);
        //health += 30f;
    }
}
