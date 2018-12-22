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
            playerControllerIntegration.playerLife += HealthToAdd;

            if (playerControllerIntegration.playerLife > 100)
            {
                playerControllerIntegration.playerLife = 100;
            }
            Destroy(gameObject);
        }
    }
}
