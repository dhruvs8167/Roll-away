using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.Advertisements;
public class AfterGame : MonoBehaviour {
    int y;
	// Use this for initialization
	void Start () {
        Advertisement.Initialize("2808674");
    }

    // Update is called once per frame
    void Update () {
		
	}
    public void Retry()
    {
        Scene scene = SceneManager.GetActiveScene();

        SceneManager.LoadScene(scene.name);
        
    }
    public void Exit()
    {
        Application.Quit();
    }
    public void Next()
    {
        y = SceneManager.GetActiveScene().buildIndex;
        PlayerPrefs.SetInt("levellock", y);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        if (Advertisement.IsReady())
        {
            Advertisement.Show();
        }

    }
    public void Mainmenu()
    {
        SceneManager.LoadScene("Main Menu");
        if (Advertisement.IsReady())
        {
            Advertisement.Show();
        }
    }
}
