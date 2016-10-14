using UnityEngine;
using System.Collections;

public class AsteroidScript : MonoBehaviour
{
    public float speed;
    private Rigidbody rb;
    public Movement myMovement;

    void FixedUpdate()
    {
        /*float moveHorizontal = -1;
        Vector3 movement = new Vector3(moveHorizontal, 0.0f, 0.0f);
        rb = GetComponent<Rigidbody>();
        rb.AddForce(movement * speed);*/
        myMovement.Move(transform);
    }
}
