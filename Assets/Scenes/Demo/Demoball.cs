using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Demoball : MonoBehaviour
{
    public AudioSource bounce;
    
    public AudioClip bounceclip;
    Rigidbody rb;
    private Vector3 fp;   //First touch position
    private Vector3 lp;   //Last touch position
    private float dragDistance;  //minimum distance for a swipe to be registered
    
    
    bool groundContact = true;
    public GameObject ui;
    public GameObject cube;
    void Start()
    {
        
        bounce.clip = bounceclip;
        dragDistance = Screen.height * 5 / 100; //dragDistance is 15% height of the screen
        
    }

    void Update()
    {
     //   var rigidbody = GetComponent<Rigidbody>();
     //   Vector3 move = new Vector3(joystick.Horizontal * 50f, -20f, joystick.Vertical * 50f);
     //   rigidbody.AddForce(move);

        if (groundContact)
        {
            Vector3 jump = new Vector3(0.0f, 300.0f, 300.0f);
            
         //   GetComponent<Rigidbody>().AddForce(jump);
            rb = GetComponent<Rigidbody>();
            rb.AddForce(jump);
           // rb.MovePosition(transform.position +(transform.up *100* Time.deltaTime));
            groundContact = false;
        }

        if (Input.touchCount == 1) // user is touching the screen with a single touch
        {
            Touch touch = Input.GetTouch(0); // get the touch
            if (touch.phase == TouchPhase.Began) //check for the first touch
            {
                fp = touch.position;
                lp = touch.position;
            }
            else if (touch.phase == TouchPhase.Moved) // update the last position based on where they moved
            {
                lp = touch.position;
            }
            else if (touch.phase == TouchPhase.Ended) //check if the finger is removed from the screen
            {
                lp = touch.position;  //last touch position. Ommitted if you use list

                //Check if drag distance is greater than 20% of the screen height
                if (Mathf.Abs(lp.x - fp.x) > dragDistance || Mathf.Abs(lp.y - fp.y) > dragDistance)
                {//It's a drag
                 //check if the drag is vertical or horizontal
                    if (Mathf.Abs(lp.x - fp.x) > Mathf.Abs(lp.y - fp.y))
                    {   //If the horizontal movement is greater than the vertical movement...
                        if ((lp.x > fp.x))  //If the movement was to the right)
                        {   //Right swipe
                            Vector3 right = new Vector3(500.0f, 0.0f, 0.0f);
                            GetComponent<Rigidbody>().AddForce(right);
                        }
                        else
                        {   //Left swipe
                            Vector3 right = new Vector3(-500.0f, 0.0f, 0.0f);
                            GetComponent<Rigidbody>().AddForce(right);
                        }
                    }
                    else
                    {   //the vertical movement is greater than the horizontal movement
                        if (lp.y > fp.y)  //If the movement was up
                        {   //Up swipe
                            
                        }
                        else
                        {   //Down swipe
                            Vector3 down = new Vector3(0.0f, -300.0f, 0.0f);
                            GetComponent<Rigidbody>().AddForce(down);

                        }
                    }
                }
                else
                {   //It's a tap as the drag distance is less than 20% of the screen height
                    
                }
            }
        }
    }
   
    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.tag == "c")
        {
            groundContact = true;
            bounce.Play();



        }
        if (col.gameObject.tag == "f")
        {
            ui.SetActive(true);
            Object.Destroy(gameObject);
        }
        if (col.gameObject.tag == "cube")
        {
            cube.SetActive(true);
            Object.Destroy(gameObject);
        }
        if(col.gameObject.tag == "j")
        {
            Vector3 j = new Vector3(0.0f, 1000.0f, 0.0f);
            GetComponent<Rigidbody>().AddForce(j);
        }
       
    }
}