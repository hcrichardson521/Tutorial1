using UnityEngine;
using System.Collections;

[System.Serializable]
public class AngleMovement : Movement
{
    public override void Move(Transform toMove)
    {
        toMove.position = toMove.position + (toMove.forward * .1f);
        Vector3 eulerVector = toMove.rotation.eulerAngles;
        Vector3 newVector = new Vector3();
        newVector.x = Random.Range(-9, 10);
        newVector.y = Random.Range(-9, 10);
        newVector.z = Random.Range(-9, 10);
        eulerVector = eulerVector + newVector;
        toMove.rotation = Quaternion.Euler(eulerVector);
    }
}
