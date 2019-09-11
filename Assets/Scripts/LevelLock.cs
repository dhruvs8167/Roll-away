using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelLock : MonoBehaviour {
    public GameObject two;
    public GameObject three;
    public GameObject four;
    public GameObject five;
    public GameObject six;
    public GameObject seven;
    public GameObject eight;
    public GameObject nine;
    public GameObject ten;
    int v;
    // Use this for initialization
    void Start () {
        
        v = PlayerPrefs.GetInt("levellock");
    }
	
	// Update is called once per frame
	void Update () {
        
        if (v >= 1)
        {
            two.SetActive(false);
        }
        if (v >= 2)
        {
            three.SetActive(false);
        }
        if(v >= 3)
        {
            four.SetActive(false);
        }
        if(v >= 4)
        {
            five.SetActive(false);
        }
        if (v >= 5)
        {
            six.SetActive(false);
        }
        if (v >= 6)
        {
            seven.SetActive(false);
        }
        if(v >= 7)
        {
            eight.SetActive(false);
        }
        if (v >= 8)
        {
            nine.SetActive(false);
        }
        if (v >= 9)
        {
            ten.SetActive(false);
        }
        
	}
}
