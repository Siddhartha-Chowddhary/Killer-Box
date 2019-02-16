using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraShake : MonoBehaviour {

    public Animator CamAnim;

    public void CamShake()
    {
        CamAnim.SetTrigger("Shake");
    }
}
