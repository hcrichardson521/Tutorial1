using UnityEngine;
using System.Collections;

public class SpawnLiftsScript : MonoBehaviour
{
    public GameObject lift;
    public float spawnWait;
    public float startWait;
    public float waveWait;

    void Start()
    {
        StartCoroutine(SpawnWaves());
    }

    IEnumerator SpawnWaves()
    {
        yield return new WaitForSeconds(startWait);
        while (true)
        {
            Vector3 spawnPosition = new Vector3(9, -2, 10);
            Quaternion spawnRotation = Quaternion.identity;
            Object liftObject = Instantiate(lift, spawnPosition, spawnRotation);
            GameObject liftGameObject = (GameObject)liftObject;
            yield return new WaitForSeconds(spawnWait);
            yield return new WaitForSeconds(waveWait);
        }
    }
}
