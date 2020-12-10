using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class PlayerMovement : MonoBehaviour
{

    public Image healthBarImage;

    public CharacterController2D controller;

    public float runSpeed = 80f;

    float horizontalMove = 0f;

    bool jump = false;

    bool crouch = false;

    public float health;
    public float maxHealth = 10f;

    bool sleeping = false;
    float runTimer = 0f;

    public GameObject respawnPoint;

    public AudioClip collectSound;
    AudioSource audioSource;

    public bool onGround = false;

    public GameObject WinScreen;

    public void Start()
    {
        //health bar fill 
        //health = maxHealth;
        //healthBarImage.fillAmount = 1f;
        // healthBarImage.fillAmount = health / maxHealth;

        audioSource = GetComponent<AudioSource>();
    }
    void Update()
    {

        if (sleeping)
        {
            //health += 6 * Time.deltaTime;
            //healthBarImage.fillAmount = health / maxHealth;
            runSpeed = 0;
            //controller.enabled = false;
            controller.Move(0f, crouch, jump);

        }
        else
        {
            //health -= 5 * Time.deltaTime;
            //healthBarImage.fillAmount = health / maxHealth;
            controller.enabled = true;
            controller.Move(horizontalMove * Time.fixedDeltaTime, crouch, jump);
        }

        if (health >= maxHealth)
        {
            health = maxHealth;
            sleeping = false;
        }
        if (health <= 0)
        {
            health = 0;
            sleeping = true;
        }
        if (runTimer > 0)
        {
            runTimer -= Time.deltaTime;
            runSpeed = 100f;
        }
        else
        {
            runSpeed = 80f;
        }
        if (gameObject.transform.position.y < -20)
        {
            gameObject.transform.position = respawnPoint.transform.position;
        }

        jump = false;
    }

    void FixedUpdate()
    {
        //movement
        horizontalMove = Input.GetAxisRaw("Horizontal") * runSpeed;
        if (Input.GetButtonDown("Jump") && onGround)
        {
            Debug.Log("jumping");
            jump = true;
        }
        if (Input.GetButtonDown("Crouch"))
        {
            crouch = true;
        }
        else if (Input.GetButtonUp("Crouch"))
        {
            crouch = false;
        }

    }

    void DestroyMyself()
    {
        Destroy(gameObject);
    }

    void OnTriggerEnter2D(Collider2D other)
    {

        if (other.gameObject.CompareTag("Sleep"))
        {
            //("DestoyMyself", 0.1f);
            
            healthBarImage.fillAmount += 1f;
            healthBarImage.fillAmount = health / maxHealth;
            audioSource.PlayOneShot(collectSound, 1F);
            health += 30f;
        }

        if (other.gameObject.CompareTag("Pickup"))
        {
            Destroy(other.gameObject);
            healthBarImage.fillAmount += 1f;
            healthBarImage.fillAmount = health / maxHealth;
            audioSource.PlayOneShot(collectSound, 1F);
            health += 10f;
        }

        if (other.gameObject.CompareTag("SpeedBoost"))
        {
            Destroy(other.gameObject);
            healthBarImage.fillAmount += 1f;
            healthBarImage.fillAmount = health / maxHealth;
            audioSource.PlayOneShot(collectSound, 1F);
            health -= 5f;
            runTimer = 10f;
            Debug.Log("Fast");
        }
        if (other.gameObject.CompareTag("Platforms"))
        {
            onGround = true;
        }

        if (other.gameObject.CompareTag("Bed"))
        {
            WinScreen.SetActive(true);
            controller.gameObject.SetActive(false);
        }
    }

    void OnTriggerExit2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Platforms"))
        {
            onGround = false;
        }
    }
}
