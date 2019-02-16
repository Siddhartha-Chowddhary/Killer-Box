using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthHelper : MonoBehaviour
{

    public static float HealthAmount;
    public GameObject effect;

    public float Speed;
    private Transform PlayerPosition;
    private Hero player;


    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").GetComponent<Hero>();
        PlayerPosition = GameObject.FindGameObjectWithTag("Player").transform;
    }

    void Update()
    {
        transform.position = Vector2.MoveTowards(transform.position, PlayerPosition.position, Speed * Time.deltaTime);
    }
   
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag.Equals("Player"))
        {
            Instantiate(effect, transform.position, Quaternion.identity);
            Destroy(collision.gameObject);
            HealthAmount += 0.5f;
        }
    }
}
