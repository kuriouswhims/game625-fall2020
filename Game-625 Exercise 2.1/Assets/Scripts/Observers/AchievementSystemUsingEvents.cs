using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AchievementSystemUsingEvents : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        ItemCollectionNotifier.OnItemCollected += UnlockItemCollectedAchievement;
    }

    // Update is called once per frame
    private void UnlockItemCollectedAchievement(ItemCollectionNotifier c)
    {
        Debug.Log("Congrats, you got something!");
    }
}
