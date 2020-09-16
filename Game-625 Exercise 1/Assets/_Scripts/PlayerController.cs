using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 5f;
    Repository repOfBalls = new Repository();
    Rigidbody rb;
    public Transform player;
    

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
        //player = GetComponent<Transform>();

    }

    private void Update()
    {
        
        float xMov = Input.GetAxisRaw("Horizontal");
        float zMov = Input.GetAxisRaw("Vertical");

        rb.velocity = new Vector3(xMov, rb.velocity.y, zMov) * speed * Time.deltaTime;

        if (Input.GetKeyDown(KeyCode.E))
        {
            dropElement();
        }
        
    }

    void dropElement()
    {
        Balls lastOne = Repository.listOfBalls[Repository.listOfBalls.Count - 1];
        Repository.listOfBalls.RemoveAt(Repository.listOfBalls.Count - 1);
        lastOne.gameObject.SetActive(true);
        lastOne.transform.position = player.transform.position + new Vector3(player.position.x -0.2f,0,player.position.z -0.2f);
        Debug.Log("I am a childless Millenial");
    }
}
