using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class TimeManager : MonoBehaviour
{
    public float startingTime;
    private TextMeshProUGUI theText;

    public GameObject gameOverScreen;
    public CharacterController2D controller;


    void Start()
    {
        theText = gameObject.GetComponent<TextMeshProUGUI>();
        controller = FindObjectOfType<CharacterController2D> ();
    }

    void Update()
    {
        startingTime -= Time.deltaTime;

        if (startingTime <= 0)
        {
            gameOverScreen.SetActive(true);
            controller.gameObject.SetActive(false);
        }
        theText.text = Mathf.Round(startingTime).ToString ();
    }
}
