using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlooBall : Balls
{
    public GameObject blooball;

    public override void noise()
    {
        Debug.Log("I am making a bloo sound.");
    }

    /*public override void addToRepository()
    {
        base.addToRepository();
        listOfBalls.Add(blooball);
    }*/
}