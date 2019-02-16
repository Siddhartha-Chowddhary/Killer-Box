using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hero: MonoBehaviour
{

    public float Speedx;
    public float Speedy;
    public static float HealthAmount;

    public Joystick Joystick; 

    bool FaceingRight;

    float Speed;
    float Speeddy;

    Rigidbody2D rb;
    public GameObject effect;

    void Start()
    {
        HealthAmount = 1;
        rb = GetComponent<Rigidbody2D>();
        FaceingRight = true;
    }

    void Update()
    {
        PlayerMovement(Speed);
        PlayerAtYAxis(Speeddy);

        float x = Joystick.Horizontal;
        float y = Joystick.Vertical;

       /* if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            Speed = Speedx;
        }
        if (Input.GetKeyUp(KeyCode.UpArrow))
        {
            Speed = 0;
        }

        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            Speed = -Speedx;
        }
        if (Input.GetKeyUp(KeyCode.DownArrow))
        {
            Speed = 0;
        }
        if (Speeddy > 0 && !FaceingRight || Speeddy < 0 && FaceingRight)
        {
            Flip();
        }
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            Speeddy = -Speedy;
        }
        if (Input.GetKeyUp(KeyCode.LeftArrow))
        {
            Speeddy = 0;
        }
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            Speeddy = Speedy;
        }
        if (Input.GetKeyUp(KeyCode.RightArrow))
        {
            Speeddy = 0;
        }
        */
        if (HealthAmount <= 0)
        {
            Destroy(gameObject);
        }
    }
    void PlayerMovement(float PlayerSpeed)
    {
       
        rb.velocity = new Vector3(Speed, rb.velocity.y, 0);
    }
    void PlayerAtYAxis(float PlayerSpeed)
    {

        rb.velocity = new Vector3(Speeddy, rb.velocity.x, 0);
    }

    void Flip()
    {
        FaceingRight = !FaceingRight;
        Vector3 Scale = transform.localScale;
        Scale.x *= -1;
        transform.localScale = Scale;
    }
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag.Equals("Enemy"))
        {
            Instantiate(effect, transform.position, Quaternion.identity);
            Destroy(collision.gameObject);
            HealthAmount -= 0.1f;
        }

        if (collision.gameObject.tag.Equals("Monster"))
        {
            Instantiate(effect, transform.position, Quaternion.identity);
            Destroy(collision.gameObject);
            HealthAmount -= 0.5f;
        }
        if (collision.gameObject.tag.Equals("Health Helper"))
        {
            Instantiate(effect, transform.position, Quaternion.identity);
            Destroy(collision.gameObject);
            HealthAmount += 0.5f;
        }
    }
/*
    public void WalkLeft()
    {
        Speeddy = -Speedy;
    }
    public void WalkRight()
    {
        Speeddy = Speedy;
    }
    public void Stop()
    {
        Speed = 0;
    }
    public void WalkUP()
    {
        Speed = Speedx;
    }
    public void WalkDown()
    {
        Speed = -Speedx;
    }
*/
}
