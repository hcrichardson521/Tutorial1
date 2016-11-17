using UnityEngine;
using System.Collections;

public class Rotator : MonoBehaviour {

	IEnumerator OnTriggerEnter(Collider col){
		yield return new WaitForSeconds (1.0f);
		Quaternion fromRotation = transform.rotation; 
		Quaternion toRotation = Quaternion.Euler(0,180,0);
		transform.rotation = Quaternion.Lerp(fromRotation,toRotation,Time.deltaTime * 10);
		yield return new WaitForSeconds (4.0f);
		ResetRotation ();

	}

	void ResetRotation() {
		transform.rotation = Quaternion.Euler(0,0,0);
	}

}