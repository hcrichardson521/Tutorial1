using UnityEngine;
using System.Collections;

public class SpawnAsteroidScript : MonoBehaviour {

    public GameObject asteroid;
    public Vector3 spawnValues=new Vector3(5,1,5);
    public int asteroidCount;
    public float spawnWait;
    public float startWait;
    public float waveWait;
    public Movement myBehavior;

    void Start()
    {
        StartCoroutine(SpawnWaves());
    }

    IEnumerator SpawnWaves()
    {
        yield return new WaitForSeconds(startWait);
        while (true)
        {
            for (int i = 0; i < asteroidCount; i++)
            {
                Vector3 spawnPosition = new Vector3(Random.Range(-5,5), Random.Range(-5, 5), spawnValues.z);
                Quaternion spawnRotation = Quaternion.identity;
                Object asteroidObject=Instantiate(asteroid, spawnPosition, spawnRotation);
                GameObject asteroidGameObject = (GameObject)asteroidObject;
                AsteroidScript asteroidScript=asteroidGameObject.GetComponent<AsteroidScript>();
                int num = Random.Range(1, 5);
                if (num == 1)
                {
                    myBehavior = new JitterMovement();
                }
                else if(num==2)
                {
                    myBehavior = new StraightMovement();
                }
                else if(num==3)
                {
                    myBehavior = new AngleMovement();
                }
                else if(num==4)
                {
                    myBehavior = new FastMovement();
                }
                asteroidScript.myMovement = myBehavior;
                yield return new WaitForSeconds(spawnWait);
            }
            yield return new WaitForSeconds(waveWait);
        }
    }
}
