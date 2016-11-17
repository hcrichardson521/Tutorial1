using UnityEngine;
using System.Collections;
using System;
public class bkSwitchScript : MonoBehaviour {

    private bool turn = false;
    public Vector3 eulerAngleVelocity;
    private Rigidbody rb;
    public GameObject bkSwitch;
    
    Collider col;
    Quaternion originalRotation; 
    void Start()
    {
        col = bkSwitch.GetComponent<Collider>();
        GameObject Lever = GameObject.Find("InclineSlide2");
        rb = Lever.GetComponent<Rigidbody>();

        originalRotation = rb.rotation;
    }
    void Update()
    {

        if (Input.GetMouseButtonDown(0))
        {

            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            if(col.Raycast(ray, out hit, 100.0F))
            {
                turn = !turn;
            }
        }
    }

    void FixedUpdate()
    {

        Quaternion rotationVector = originalRotation;

        /*
		You can change the direction the switch turns from vertically to horizontally by changing 
		the below x-values to y-values
		*/

        if (turn == true)
        {
            rotationVector = Quaternion.Euler(-45   , -260, 0);
            Debug.Log(rotationVector);
            //rotationVector.y = 45.0f;
            transform.rotation = rotationVector;
            rb.position.Set(rb.position.x, rb.position.y, rb.position.z+2);
            rb.rotation = transform.rotation;
        }
        else if (turn == false)
        {
            Debug.Log(originalRotation);
            transform.rotation = originalRotation;
            rb.rotation = transform.rotation;
        }
    }
}
