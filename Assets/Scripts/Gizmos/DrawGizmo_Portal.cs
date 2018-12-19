using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DrawGizmo_Portal : MonoBehaviour
{
    public void OnDrawGizmos()
    {
        Gizmos.DrawIcon(transform.position, "gizmo_portal");
    }
}
