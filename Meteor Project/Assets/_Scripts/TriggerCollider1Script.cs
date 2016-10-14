using UnityEngine;
using System.Collections;

public class TriggerCollider1Script : MonoBehaviour
{
    private ArrayList asteroidList = new ArrayList();
    private GameObject other;

    void OnTriggerEnter(Collider other)
    {
        if (tag == "Planet")
        {
            return;
        }
        else
        {
            asteroidList.Add(other.gameObject);
        }
    }

    void OnTriggerExit(Collider other)
    {
        if(tag=="Planet")
        {
            return;
        }
        else
        {
            asteroidList.Remove(other.gameObject);
        }
    }

    void FixedUpdate()
    {
        for(int i=0; i<asteroidList.Count; i++)
        {
            other = (GameObject)asteroidList[i];
            if (asteroidList[i].Equals(null))
            {
                asteroidList.Remove(asteroidList[i]);
                return;
            }
            Vector3 diff = other.transform.position - transform.position;
            diff.Normalize();
            other.transform.position -= diff * .04f;
        }
    }
}
