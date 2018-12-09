using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bolt_Behaviour : MonoBehaviour
{
    public void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Wall")
        {
            Destroy(this);
        }
    }
}
