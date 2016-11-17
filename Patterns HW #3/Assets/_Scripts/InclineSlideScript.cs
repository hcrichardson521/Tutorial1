using UnityEngine;
using System.Collections;

public class InclineSlideScript : MonoBehaviour {
    GameObject ball;
    private bool addForce;
    Rigidbody rb;
	// Use this for initialization
	void Start () {
        addForce = false;
	}

    void OnTriggerEnter(Collider col)
    {
        addForce = true;
        rb = col.GetComponentInParent<Rigidbody>();
    }
    void OnTriggerExit(Collider col)
    {
        addForce = false;
    }
	
	// Update is called once per frame
	void FixedUpdate () {
        if (addForce == true)
        {
            GameObject slideTop = GameObject.Find("bkTop");
            Rigidbody rb1 = slideTop.GetComponent<Rigidbody>();
            GameObject slideBottom = GameObject.Find("bkBottom");
            Rigidbody rb2 = slideBottom.GetComponent<Rigidbody>();
            Vector3 v = (rb1.position - rb2.position) * 1.7f;

            rb.AddForce(v);
        }
    }
}
