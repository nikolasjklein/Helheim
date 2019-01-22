using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUp_Health : MonoBehaviour
{
    public PlayerController playerControllerIntegration;
    public int HealthToAdd = 15;

    public void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            if (playerControllerIntegration.pL < 100)
            {
                playerControllerIntegration.pL += HealthToAdd;

                if (playerControllerIntegration.pL > 100)
                {
                    playerControllerIntegration.pL = 100;
                }

                Destroy(gameObject);
            }

            else if (playerControllerIntegration.pL >= 100)
            {
                playerControllerIntegration.pL = 100;
            }
        }
    }
}
