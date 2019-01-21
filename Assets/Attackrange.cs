using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attackrange : MonoBehaviour
{
    public void OnTriggerStay(Collider other)
    {
        if (other.tag == "Player")
        {

        }
    }

    public void Attack()
    { }
}
