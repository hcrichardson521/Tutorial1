using UnityEngine;
using System.Collections;

[System.Serializable]
public class FastMovement : Movement
{
    public override void Move(Transform toMove)
    {
        toMove.transform.position = toMove.transform.position + (toMove.forward * 1.1f);
    }
}
