using UnityEngine;
using System.Collections;

public class Ball_Controller : MonoBehaviour 
{
	public float speed = 5.0f;
	public float slideSpeed = 1;
	private bool forward = false;
	private bool backward = false;
	private bool up = false;
    private GameObject slide1;

	void OnTriggerEnter(Collider other) 
	{
		if (other.tag == "FlatForward") {
			forward = true;
		} else if (other.tag == "FlatBackward") {
			backward = true;
		} else if (other.tag == "Slide") {
            slide1 = other.gameObject;
			up = true;
		}
	}

	void OnTriggerExit(Collider other)
	{
		if (other.tag == "FlatForward") {
			forward = false;
		} else if (other.tag == "FlatBackward") {
			backward = false;
		} else if (other.tag == "Slide"){
			up = false;
		}
	}

	void FixedUpdate()
	{

		Rigidbody rb = GetComponent<Rigidbody>();
		if (forward == true) {	
			//rb.velocity = transform.forward * speed;
			rb.AddForce(0,0,speed);
		} else if (backward == true) {	
			//rb.velocity = transform.forward * speed;
			rb.AddForce(0,0,0 - speed);
		}
        else if (up == true)
        {
            GameObject slideTop = slide1.transform.FindChild("Top").gameObject;
            Rigidbody rb1 = slideTop.GetComponent<Rigidbody>();
            GameObject slideBottom = slide1.transform.FindChild("Bottom").gameObject;
            Rigidbody rb2 = slideBottom.GetComponent<Rigidbody>();
            Vector3 v = (rb1.position - rb2.position)*1.7f*slideSpeed;
            rb.AddForce(v);

        }



    }

}