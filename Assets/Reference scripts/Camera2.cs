using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera2 : MonoBehaviour {

    [SerializeField]
    GameObject Target;

    void Update()
    {
        transform.position = new Vector3(Target.transform.position.x, 
            Target.transform.position.y - 1f, Target.transform.position.z);

    }
}
