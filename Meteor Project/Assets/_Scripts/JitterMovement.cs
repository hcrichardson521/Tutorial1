using UnityEngine;
using System.Collections;

[System.Serializable]
public class JitterMovement : Movement
{
    public override void Move(Transform toMove)
        {
            toMove.position = toMove.position + (toMove.forward * .1f);
            Vector3 jitterVector = new Vector3();
            jitterVector.x = Random.Range(-0.03f, 0.03f);
            jitterVector.y = Random.Range(-0.03f, 0.03f);
            toMove.transform.position = toMove.transform.position + jitterVector;
        }
}
