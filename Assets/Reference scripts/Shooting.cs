using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour {


    public GameObject Bullet;
    private Transform PlayerPosition;

    


    void Start () {
        PlayerPosition = GetComponent<Transform>();	
	}
	

	void Update ()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Instantiate(Bullet, PlayerPosition.position, Quaternion.identity);
        }
	}
}
