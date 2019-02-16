using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour {

    public float Speed;
    private Transform PlayerPosition;
    private Hero player;
    public GameObject effect;

	void Start ()
    {
        player = GameObject.FindGameObjectWithTag("Player").GetComponent<Hero>();
        PlayerPosition = GameObject.FindGameObjectWithTag("Player").transform;
    }
	
	void Update ()
    {
        transform.position = Vector2.MoveTowards(transform.position, PlayerPosition.position, Speed * Time.deltaTime);	
	}

     

}
