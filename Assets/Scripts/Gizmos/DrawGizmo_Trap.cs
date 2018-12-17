using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DrawGizmo_Trap : MonoBehaviour
{
    public void OnDrawGizmos()
    {
        Gizmos.DrawIcon(transform.position, "gizmo_trap2");
    }
}
