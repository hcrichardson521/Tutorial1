using UnityEngine;
using System.Collections;

public class TriggerCollider2Script : MonoBehaviour {

    void OnTriggerEnter (Collider other)
    {
            Destroy(other.gameObject);
    }
}
