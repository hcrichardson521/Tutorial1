using UnityEngine;
using System.Collections;

public class ElevatorTrigger : MonoBehaviour
{
    internal bool active = false;

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player") active = true;
    }

    void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player") active = false;
    }
}
