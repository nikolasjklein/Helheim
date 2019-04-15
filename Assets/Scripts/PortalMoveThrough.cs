using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PortalMoveThrough : MonoBehaviour
{
    public Transform PortalExitPoint;

    public void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            other.transform.position = PortalExitPoint.transform.position;
            other.transform.rotation = PortalExitPoint.transform.rotation;
        }
    }
}
