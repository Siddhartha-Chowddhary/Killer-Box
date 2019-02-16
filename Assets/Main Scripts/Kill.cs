using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Kill : MonoBehaviour {

    [SerializeField]
    GameObject DeathUI;

    Rigidbody2D rb;

    public float Speed;
    public float Tez;

    public static float HealthAmount;

    bool FaceingRight;

    public GameObject effect;
    public GameObject Movement;

    public Joystick JS;
    public Text Highscore;
    int HighSScore;

    void Start()
    {

        HealthAmount = 1;
        rb = GetComponent<Rigidbody2D>();
        FaceingRight = true;
    }

    // Update is called once per frame
    void Update()
    {

        float x = JS.Vertical;
        float y = JS.Horizontal;

        rb.velocity = new Vector3(x * Speed, rb.velocity.y, 0);
        rb.velocity = new Vector3(y * Tez, rb.velocity.x, 0);


        FaceingRight = !FaceingRight;
        Vector3 Scale = transform.localScale;
        Scale.x *= -1;
        transform.localScale = Scale;


        if (HealthAmount <= 0)
        {
            Destroy(gameObject);
            Score.Scorevalue = 0;
            DeathUI.gameObject.SetActive(true);
        }
        else if (Score.Scorevalue >= HighScore.Highscorevalue)
        {
            HighScore.Highscorevalue = Score.Scorevalue;
            LifetimeScore.Lifevalue = HighScore.Highscorevalue;
        }
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
            HealthAmount -= 0.25f;
        }
        if (collision.gameObject.tag.Equals("Health Helper"))
        {
            Instantiate(effect, transform.position, Quaternion.identity);
            Destroy(collision.gameObject);
            HealthAmount += 0.5f;
        }
    }
    void Effect()
    {
        if (rb.velocity.x > 0 || rb.velocity.y > 0)
        {
            Instantiate(Movement, transform.position, Quaternion.identity);
        }

    }
}

