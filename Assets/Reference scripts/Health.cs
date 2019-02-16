using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour {

    Vector3 LocalScale;

    
	void Start () {
        LocalScale = transform.localScale;	
	}
	
	// Update is called once per frame
	void Update () {
        LocalScale.x = Kill.HealthAmount;
        transform.localScale = LocalScale;
	}
}
