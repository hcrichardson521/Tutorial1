using UnityEngine;
using System.Collections;

public class Shooter : MonoBehaviour
{
    public GameObject sphere;

    void OnTriggerEnter()
    {
        Vector3 pos = new Vector3(20, 8, 30);
        if (sphere.transform.position.x <= 20 && sphere.transform.position.y <= 8 && sphere.transform.position.z <= 30)
        {
            sphere.transform.position = pos;
        }
    }
}
