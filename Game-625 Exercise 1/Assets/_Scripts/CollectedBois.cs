using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectedBois : MonoBehaviour
{
    void Start()
    {
        CollectableBoiNotifier.OnPinkBoiCollected += PinkBoiCollected;
        //CollectableBoiNotifier.OnBlooBoiCollected += BlooBoiCollected;
        //CollectableBoiNotifier.OnPurpleBoiCollected += PurpleBoiCollected;

    }

    private void PinkBoiCollected(CollectableBoiNotifier c)
    {
        Debug.Log("Pink Boi Collected!");
    }

    /*private void BlooBoiCollected(CollectableBoiNotifier d)
    {
        Debug.Log("Bloo Boi Collected!");
    }

    private void PurpleBoiCollected(CollectableBoiNotifier e)
    {
        Debug.Log("Purple Boi Collected!");
    }*/
}
