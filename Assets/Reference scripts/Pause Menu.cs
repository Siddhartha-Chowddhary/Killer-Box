using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour {

    public int Index;
    public string NextLevel;

	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    void Pause_Menu ()
    {
        SceneManager.LoadScene(1);
        SceneManager.LoadScene(NextLevel);
    }
}
