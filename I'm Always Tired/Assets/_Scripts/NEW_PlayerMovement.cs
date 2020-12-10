using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NEW_PlayerMovement : MonoBehaviour
{
    public NEW_CharacterController2D controller;

    public Image healthBarImage;
    float horizontalMove = 0f;
    public float runSpeed = 40f;
    bool jump = false;

    public float health;
    public float maxHealth = 10f;
    public bool onGround = false;
    //public bool isSleeping = false;
    private float time = 0f;

    [SerializeField]
    private CharacterMovement characterMovement = CharacterMovement.movePlayer;

    // Start is called before the first frame update
    void Start()
    {
        /*health = maxHealth;
        healthBarImage.fillAmount = 1f;
        healthBarImage.fillAmount = health / maxHealth;*/
    }

    // Update is called once per frame
    void Update()
    {
        horizontalMove = Input.GetAxisRaw("Horizontal") * runSpeed;

        switch (characterMovement)
        {
            case CharacterMovement.movePlayer:
                PlayerMove();
                if (time >= 10f)
                {
                    Debug.Log("Transition to sleeping");
                    PlayerSleep();
                    time = 0f;
                }
                break;
            case CharacterMovement.sleeping:
                PlayerSleep();
                if (time > 3f)
                {
                    Debug.Log("Transition to moving");
                    PlayerMove();
                    time = 0f;
                }
                break;
            default:
                break;
        }

  /*      if (Input.GetButtonDown("Jump"))
        {
            jump = true;
        }
  */
        time += Time.deltaTime;

    }



    private void PlayerMove()
    {
        characterMovement = CharacterMovement.movePlayer;
        //Debug.Log("player is moving");
        //health -= 5 * Time.deltaTime;
        runSpeed = 40;
        controller.Move(horizontalMove * Time.fixedDeltaTime, false, jump);
        //healthBarImage.fillAmount = health / maxHealth;
        //Invoke("PlayerSleep", 10);

    }


    private void PlayerSleep()
    {
        characterMovement = CharacterMovement.sleeping;
        //Debug.Log("Player is sleeping");
        //health += 6 * Time.deltaTime;
        runSpeed = 0;
        controller.Move(0f, false, false);
        //Invoke("PlayerMove", 3);

    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Platforms"))
        {
            onGround = true;
            Debug.Log("On ground");
        }
    }

    void OnTriggerExit2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Platforms"))
        {
            onGround = false;
        }
    }

    public enum CharacterMovement
    {
        movePlayer,
        sleeping, 
        jumping, 
    }
}
