using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Music : MonoBehaviour {

    public void Musical()
    {
        DontDestroyOnLoad(transform.gameObject);   
    }
}
