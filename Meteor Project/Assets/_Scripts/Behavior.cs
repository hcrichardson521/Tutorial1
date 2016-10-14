using UnityEngine;
using System.Collections;

[System.Serializable]
public abstract class Movement
{
    public abstract void Move (Transform toMove);
}