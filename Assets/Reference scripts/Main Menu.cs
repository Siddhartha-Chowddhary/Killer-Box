using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour {

    public int Index;
    public string LevelName;

   
	
	
	void Play () {

        SceneManager.LoadScene(1);
        SceneManager.LoadScene(LevelName);
    }
}
