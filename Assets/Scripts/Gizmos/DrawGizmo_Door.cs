using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DrawGizmo_Door : MonoBehaviour
{
    public void OnDrawGizmos()
    {
        Gizmos.DrawIcon(transform.position, "gizmo_door2");
    }
}
