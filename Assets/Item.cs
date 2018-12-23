using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[CreateAssetMenu(fileName = "New Item", menuName = "Inventory/Item")]

public class Item : ScriptableObject
{
    public GameObject player;

    public string itemName = "New Armor";
    public Sprite itemIcon = null;
    public string itemRarity = "Rarity";
    public int armorDefense = 00;

    public virtual void Use()
    {
        //
        Debug.Log("Using" + name);
        player = GameObject.Find("Player");
        player.GetComponentInChildren<ArmorManager>().whichArmorIsEquipped = name;
    }

    public void Update()
    {

    }
}
