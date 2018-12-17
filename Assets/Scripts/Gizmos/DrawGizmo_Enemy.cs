using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DrawGizmo_Enemy : MonoBehaviour
{
    public void OnDrawGizmos()
    {
        Gizmos.DrawIcon(transform.position, "gizmo_enemy2");
    }
}
