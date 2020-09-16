using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Balls : MonoBehaviour
{
    public static List<Balls> listOfBalls;
    public Transform player;

    protected void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            this.gameObject.SetActive(false);
            noise();
            addToRepository();
        }
    }

    public string color;
    public int size = 1; 

    public virtual void noise()
    {
        Debug.Log("I am making a sound.");
    }

    public virtual void addToRepository()
    {
        listOfBalls = new List<Balls>();
        Repository.listOfBalls.Add(this);
        Debug.Log("I'm adding some shit");
            
    }
 
}
