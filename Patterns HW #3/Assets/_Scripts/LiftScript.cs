using UnityEngine;
using System.Collections;

public class LiftScript : MonoBehaviour
{
    public static bool ballInElevator;
    public GameObject lift;
    public float spawnWait;
    public float startWait;
    public float waveWait;
    public float liftCount = 1;
    public bool notCreated=true;

    void Update()
    {
        if (ballInElevator)
        {
            if (transform.position.y < 7 && transform.position.y >= -2)
            {
                Vector3 up = new Vector3(0.0f, 0.1f, 0.0f);
                transform.position = transform.position + up;
            }
            else
            {
                if (transform.position.x < 11)
                {
                    Vector3 right = new Vector3(0.1f, 0.0f, 0.0f);
                    transform.position = transform.position + right;
                }
                else
                {
                    Vector3 original = transform.rotation.eulerAngles;
                    Vector3 rotate = new Vector3(0.0f, 0.0f, -1.5f);
                    Vector3 total = original + rotate;
                    Quaternion angle = Quaternion.Euler(total);
                    transform.rotation = angle;
                }
            }
        }
    }

    void OnTriggerEnter()
    {
        ballInElevator = true;
    }

    void OnTriggerExit()
    {
        ballInElevator = false;
        Destroy(gameObject);
    }
}
