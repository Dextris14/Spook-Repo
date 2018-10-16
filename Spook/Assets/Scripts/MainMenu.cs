using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour {
    public int LevelDied = 0;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        
	}

    public void StartGame()
    {
        SceneManager.LoadScene("Level1");
    }

    public void QuitGame()
    {
        Application.Quit();
    }

    public void Retry()
    {
        if(LevelDied == 1)
        {
            SceneManager.LoadScene("Level1");
        }
        if (LevelDied == 2)
        {
            SceneManager.LoadScene("Level2");
        }
        if (LevelDied == 3)
        {
            SceneManager.LoadScene("Level3");
        }
        if (LevelDied == 4)
        {
            SceneManager.LoadScene("Level4");
        }
        if (LevelDied == 5)
        {
            SceneManager.LoadScene("Level5");
        }
    }

    public void ReturnToMain()
    {
        SceneManager.LoadScene("MainMenu");
    }
}
