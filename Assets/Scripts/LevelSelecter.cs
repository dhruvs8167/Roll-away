using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Advertisements;

public class LevelSelecter : MonoBehaviour {
    void Start()
    {
        Advertisement.Initialize("2808674");
    }

    public void One()
    {
        SceneManager.LoadScene("one");
        if (Advertisement.IsReady())
        {
            Advertisement.Show();
        }
    }
    public void Two()
    {
        SceneManager.LoadScene("two");
        if (Advertisement.IsReady())
        {
            Advertisement.Show();
        }
    }
    public void Three()
    {
        SceneManager.LoadScene("three");
        if (Advertisement.IsReady())
        {
            Advertisement.Show();
        }
    }
    public void Four()
    {
        SceneManager.LoadScene("four");
        if (Advertisement.IsReady())
        {
            Advertisement.Show();
        }
    }
    public void Five()
    {
        SceneManager.LoadScene("five");
        if (Advertisement.IsReady())
        {
            Advertisement.Show();
        }
    }
    public void Six()
    {
        SceneManager.LoadScene("six");
        if (Advertisement.IsReady())
        {
            Advertisement.Show();
        }
    }
    public void Seven()
    {
        SceneManager.LoadScene("seven");
        if (Advertisement.IsReady())
        {
            Advertisement.Show();
        }
    }
    public void Eight()
    {
        SceneManager.LoadScene("eight");
        if (Advertisement.IsReady())
        {
            Advertisement.Show();
        }
    }
    public void Nine()
    {
        SceneManager.LoadScene("nine");
        if (Advertisement.IsReady())
        {
            Advertisement.Show();
        }
    }
    public void Ten()
    {
        SceneManager.LoadScene("ten");
        if (Advertisement.IsReady())
        {
            Advertisement.Show();
        }
    }
    public void Exit()
    {
        Application.Quit();
    }
}
