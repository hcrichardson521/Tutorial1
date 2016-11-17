using UnityEngine;
using System.Collections;

public class cameraScript : MonoBehaviour {
    public float inputX;
    public float inputZ;

	// Use this for initialization
	void Start () {
	
	}

    void Update()
    {
        inputX = Input.GetAxis("Horizontal");
        inputZ = Input.GetAxis("Vertical");

        if (inputX != 0)
            rotate();
        if (inputZ != 0)
            move();
    }

    void rotate()
    {
        transform.Rotate(new Vector3(0f, inputX * Time.deltaTime * 10f, 0f));
    }

    void move()
    {
        transform.Rotate(new Vector3(-inputZ * Time.deltaTime * 10f, 0f, 0f));
    }
}
