using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinScore : MonoBehaviour {
    private CubeManager Scr;
    
	// Use this for initialization
	void Start () {
        Scr = FindObjectOfType<CubeManager>();

	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnTriggerEnter(Collider col)
    {
        
        if (col.gameObject.tag == "player")
        {
            
            Destroy(gameObject);
            Scr.Score();
        }
    }
}
