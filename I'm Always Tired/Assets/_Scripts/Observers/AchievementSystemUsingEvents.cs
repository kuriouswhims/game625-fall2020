using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AchievementSystemUsingEvents : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Soap.OnSoapCollected += SoapCollected;
        Coffee.OnCoffeeCollected += CoffeeCollected;
    }

    // Update is called once per frame
    private void SoapCollected (Soap soap)
    {
        Debug.Log("S O A P");
        ObjectPooler._instance.ReturnToPool(ObjectType.Soap, soap.gameObject);

    }

    private void CoffeeCollected(Coffee c)
    {
        Debug.Log("Coffee collected");
    }
}
