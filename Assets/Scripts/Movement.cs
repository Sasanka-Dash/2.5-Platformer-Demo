using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public float speed = 30f; // Speed of movement
    
    
    public bool isMovingUp = false;
    public bool isMovingDown = false;
    public bool isMovingLeft = false;
    public bool isMovingRight = false;

    // Update is called once per frame
    void Update()
    {
        // Move left when 'A' is pressed
        if (isMovingLeft)
        {
            Left();
        }

        // Move right when 'D' is pressed
        if (isMovingRight)
        {
            Right();
        }

        // Move up when 'W' is pressed
        if (isMovingUp)
        {
            Up();
        }

        // Move down when 'S' is pressed
        if (isMovingDown)
        {
            Down();
        }

        // Rotate left when 'Q' is pressed
        if (Input.GetKey(KeyCode.Q))
        {
            transform.Rotate(Vector3.up, -speed * Time.deltaTime);
        }

        // Rotate right when 'E' is pressed
        if (Input.GetKey(KeyCode.E))
        {
            transform.Rotate(Vector3.up, speed * Time.deltaTime);
        }
   }

   public void TriggerUp(bool canMove)
   {
    isMovingUp = canMove;
   }

   public void TriggerDown(bool canMove)
   {
    isMovingDown = canMove;
   }

   public void TriggerLeft(bool canMove)
   {
    isMovingLeft = canMove;
   }

   public void TriggerRight(bool canMove)
   {
    isMovingRight = canMove;
   }

   public void Up()
   {
    transform.Translate(Vector3.up * speed * Time.deltaTime);
   }

   public void Down()
   {
    transform.Translate(Vector3.down * speed * Time.deltaTime);
   }

   public void Left()
   {
    transform.Translate(Vector3.left * speed * Time.deltaTime);
   }

   public void Right()
   {
    transform.Translate(Vector3.right * speed * Time.deltaTime);
   }

   // This method is called when a Collider enters this GameObject's collider.
    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("Collision entered with: " + collision.gameObject.name);
        // Do something when a collision enters
    }

    // This method is called when a Collider exits this GameObject's collider.
    private void OnCollisionExit(Collision collision)
    {
        Debug.Log("Collision exited with: " + collision.gameObject.name);
        // Do something when a collision exits
    }

    // This method is called when another Collider enters a trigger collider attached to this GameObject.
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Trigger entered with: " + other.gameObject.name);
        // Do something when a trigger enters

        if(other.gameObject.tag == "Coin")
        {
            GameManager.Instance.CoinCollect();
            //CoinCollected = CoinCollected + 1;
            //CoinCollected += 1;

            SoundManager.Instance.CoinSound();
            
            Destroy(other.gameObject);
        }
    }

    // This method is called when another Collider exits a trigger collider attached to this GameObject.
    private void OnTriggerExit(Collider other)
    {
        Debug.Log("Trigger exited with: " + other.gameObject.name);
        // Do something when a trigger exits
    }
}