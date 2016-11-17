using UnityEngine;
using System.Collections;

public class bkSceneScript : MonoBehaviour {

    GameObject ball;
    private bool addForce;
    Rigidbody rb;
    // Use this for initialization
    void Start()
    {
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
    void FixedUpdate()
    {
        if (addForce == true)
        {
            GameObject end1 = GameObject.FindGameObjectWithTag("end1");
            Rigidbody rb1 = end1.GetComponent<Rigidbody>();
            Vector3 v = (rb1.position - rb.position) * 1.5f;

            rb.AddForce(v);
        }
    }
}
