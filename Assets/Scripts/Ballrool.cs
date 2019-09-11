using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ballrool : MonoBehaviour {


    protected Joystick joystick;
    protected JoyButton joybutton;
    bool groundContact = true;
    public GameObject ui;
    public GameObject cube;
    void Start ()
    {
        joystick = FindObjectOfType<Joystick>();
        joybutton = FindObjectOfType<JoyButton>();
    }

    void Update()
    {
        var rigidbody = GetComponent<Rigidbody>();
        Vector3 move = new Vector3(joystick.Horizontal * 50f, -20f, joystick.Vertical * 50f);
        rigidbody.AddForce(move);
    }
    public void Jump()
    {
        if (groundContact)
        {
            Vector3 jump = new Vector3(0.0f, 600.0f, 0.0f);
            GetComponent<Rigidbody>().AddForce(jump);
            groundContact = false;
        }
    }
    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.tag == "c")
        {
            groundContact = true;


        }
        if(col.gameObject.tag == "f")
        {
            ui.SetActive(true);
            Object.Destroy(gameObject);
        }
        if(col.gameObject.tag == "cube")
        {
            cube.SetActive(true);
            Object.Destroy(gameObject);
        }
    }
}