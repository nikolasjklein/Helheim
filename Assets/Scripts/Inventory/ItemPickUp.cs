using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemPickUp : MonoBehaviour
{
    public Item item;

    public void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            Debug.Log("Picked Up" + item.name);
            bool wasPickedUp = Inventory.instance.Add(item);

            if (wasPickedUp)
            {
                Destroy(gameObject);
            }
        }
    }
}
