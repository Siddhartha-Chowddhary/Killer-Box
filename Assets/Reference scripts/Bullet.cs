using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using EZCameraShake;

public class Bullet : MonoBehaviour {

    private Vector2 target;
    public float Speed;
    public GameObject effect;
    public static float HealthAmount;

    


    void Start ()
    {
        target = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        HealthAmount = 1;
  
    }

    void Update()
    {
        
        transform.position = Vector3.MoveTowards(transform.position, target, Speed * Time.deltaTime);

        if (Vector3.Distance(transform.position, target) < 0.2f)
        {
            Destroy(gameObject);
        }
       /* if (Score.Scorevalue <= HighScore.Highscorevalue)
        {
            HighScore.Highscorevalue = HighScore.Highscorevalue;
            LifetimeScore.Lifevalue = HighScore.Highscorevalue;

        }*/
    
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
      

        if (collision.gameObject.tag.Equals("Enemy"))
        {
            Instantiate(effect, transform.position, Quaternion.identity);
            Destroy(collision.gameObject);
            Destroy(gameObject);
            Score.Scorevalue += 10;

            CameraShaker.Instance.ShakeOnce(4f, 4f, .1f, 1f);
        }

        if (collision.gameObject.tag.Equals("Monster"))
        {
            Instantiate(effect, transform.position, Quaternion.identity);
            Destroy(collision.gameObject);
            Destroy(gameObject);
            Score.Scorevalue += 20;

            CameraShaker.Instance.ShakeOnce(4f, 4f, .1f, 1f);
        }

        if (collision.gameObject.tag.Equals("Health Helper"))
        {
            Instantiate(effect, transform.position, Quaternion.identity);
            Destroy(collision.gameObject);
            Destroy(gameObject);
            HealthAmount += 0.2f;
            CameraShaker.Instance.ShakeOnce(4f, 4f, .1f, 1f);
        }
    }

}
