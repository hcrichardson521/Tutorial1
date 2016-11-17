using UnityEngine;
using System.Collections;

public class Switch_Controller : MonoBehaviour {
	public bool turnt = true;
	public Vector3 eulerAngleVelocity;
	public Rigidbody rb;
		
	void Update()
	{
		if (Input.GetMouseButtonDown(0) && turnt == false)
		{
			turnt = true;
		}
		else if (Input.GetMouseButtonDown(0) && turnt == true)
		{
			turnt = false;
		}
	}

	void FixedUpdate()
	{
		GameObject Lever = GameObject.Find("Lever");
		Rigidbody rb = Lever.GetComponent<Rigidbody>();

		/*
		You can change the direction the switch turns from vertically to horizontally by changing 
		the below x-values to y-values
		*/

		if (turnt == true) 
		{
			var rotationVector = transform.rotation.eulerAngles;
			rotationVector.x = 45.0f;
			//rotationVector.y = 45.0f;
			transform.rotation = Quaternion.Euler(rotationVector);
	
			rb.rotation = transform.rotation;
		} 
		else if (turnt == false)
		{
			var rotationVector = transform.rotation.eulerAngles;
			rotationVector.x = -45.0f;
			//rotationVector.y = -45.0f;
			transform.rotation = Quaternion.Euler(rotationVector);

			rb.rotation = transform.rotation;
		}
	}
}
