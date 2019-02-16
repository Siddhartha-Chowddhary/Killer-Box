using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Main : MonoBehaviour
{

    public int Index;
    public string LevelName;

     void Start()
    {
        
    }

    void Update()
    {
        
    }

   public void Play()
    {
        SceneManager.LoadScene(1);
        SceneManager.LoadScene(LevelName);
    }
}
