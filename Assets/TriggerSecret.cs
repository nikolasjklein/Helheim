using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerSecret : MonoBehaviour
{
    public SecretsFoundStatsHolder secretFoundStatsHolder;
    public bool foundSecret;

	void Start ()
    {
        foundSecret = false;
	}
	
	void Update ()
    {
		
	}

    public void OnTriggerStay(Collider other)
    {
        Debug.Log("Player is in Trigger Area");

        if (other.tag == "Player")
        {
            Debug.Log("Player is tagged Player");

            if (Input.GetKeyDown(KeyCode.Space))
            {
                if (!foundSecret)
                {
                    Debug.Log("Pressed Space");
                    secretFoundStatsHolder.FoundNewSecret();
                    foundSecret = true;
                }
                
                else
                {
                    Debug.Log("Already found Secret!");
                }
            }
        }
    }
}
