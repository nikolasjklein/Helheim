using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoltController : MonoBehaviour
{
    public float speed;

    public void Start()
    {
        
    }

    public void Update()
    {
        transform.Translate(Vector3.forward * speed * Time.deltaTime);
    }
}
