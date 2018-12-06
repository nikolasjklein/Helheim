using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RapidCrossbowController : MonoBehaviour
{
    public bool isFiring;

    public BoltController bolt;
    public float boltSpeed;

    public float timeBetweenShots;
    private float shotCounter;

    public Transform boltOriginPoint;

    public void Start()
    {
        
    }

    public void Update()
    {
        if (isFiring)
        {
            shotCounter -= Time.deltaTime;
            if (shotCounter <= 0)
            {
                shotCounter = timeBetweenShots;
                BoltController newBolt = Instantiate(bolt, boltOriginPoint.position, boltOriginPoint.rotation) as BoltController;
                newBolt.speed = boltSpeed;
            }
        }

        else
        {
            shotCounter = 0;
        }
    }
}
