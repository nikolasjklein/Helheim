using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClearInventoryOnStartup : MonoBehaviour
{
    public InventoryUI inventory;
    public GameObject inventoryGameObject;

    public void Awake()
    {
        //disable GameObject which contains the prefab slots on awake - this gets re-enabled when the first item gets added
        inventoryGameObject.gameObject.SetActive(false);
    }
}
