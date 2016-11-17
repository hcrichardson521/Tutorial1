using UnityEngine;
using System.Collections;

public class ButtonScript : MonoBehaviour
{
    public GameObject TrackPiece;
    bool Active = true;
	
	void OnMouseDown()
    {
        if (Active)
        {
            TrackPiece.active = false;
            Active = false;
        }
        else
        {
            TrackPiece.active = true;
            Active = true;
        }
    }
}
