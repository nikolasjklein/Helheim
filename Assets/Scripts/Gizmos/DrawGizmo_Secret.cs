using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DrawGizmo_Secret : MonoBehaviour
{
    public void OnDrawGizmos()
    {
        Gizmos.DrawIcon(transform.position, "gizmo_secret2");
    }
}
