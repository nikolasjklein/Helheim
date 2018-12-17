using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DrawGizmo_HealthPickUp : MonoBehaviour
{
    public void OnDrawGizmos()
    {
        Gizmos.DrawIcon(transform.position, "gizmo_healthpickup2");
    }
}
