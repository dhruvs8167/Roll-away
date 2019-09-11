using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;
public class JoyButton : MonoBehaviour {
   // public GameObject g;
   // Rigidbody rb;
	// Use this for initialization
	void Start () {
     //   rb = g.GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void Update () {
        
    }
    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.tag == "c")
        {

            Vector3 jump = new Vector3(0.0f, 2000.0f, 0.0f);
            GetComponent<Rigidbody>().AddForce(jump);
        }
    }
}
