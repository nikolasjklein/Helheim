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

        if (name == "LeatherArmor" && player.GetComponentInChildren<ArmorManager>().whichArmorIsEquipped == "LeatherArmor")
        {
            player.GetComponentInChildren<ArmorManager>().whichArmorIsEquipped = "Unarmored";
        }

        else if (name == "BoarHideArmor" && player.GetComponentInChildren<ArmorManager>().whichArmorIsEquipped == "BoarHideArmor")
        {
            player.GetComponentInChildren<ArmorManager>().whichArmorIsEquipped = "Unarmored";
        }

        else if (name == "WolfSkinArmor" && player.GetComponentInChildren<ArmorManager>().whichArmorIsEquipped == "WolfSkinArmor")
        {
            player.GetComponentInChildren<ArmorManager>().whichArmorIsEquipped = "Unarmored";
        }

        else if (name == "ChainmailArmor" && player.GetComponentInChildren<ArmorManager>().whichArmorIsEquipped == "ChainmailArmor")
        {
            player.GetComponentInChildren<ArmorManager>().whichArmorIsEquipped = "Unarmored";
        }

        else if (name == "AncientArmor" && player.GetComponentInChildren<ArmorManager>().whichArmorIsEquipped == "AncientArmor")
        {
            player.GetComponentInChildren<ArmorManager>().whichArmorIsEquipped = "Unarmored";
        }

        else if (name == "RunicArmor" && player.GetComponentInChildren<ArmorManager>().whichArmorIsEquipped == "RunicArmor")
        {
            player.GetComponentInChildren<ArmorManager>().whichArmorIsEquipped = "Unarmored";
        }

        else if (name == "SlaughterersArmor" && player.GetComponentInChildren<ArmorManager>().whichArmorIsEquipped == "SlaughterersArmor")
        {
            player.GetComponentInChildren<ArmorManager>().whichArmorIsEquipped = "Unarmored";
        }

        else if (name == "MithrilArmor" && player.GetComponentInChildren<ArmorManager>().whichArmorIsEquipped == "MithrilArmor")
        {
            player.GetComponentInChildren<ArmorManager>().whichArmorIsEquipped = "Unarmored";
        }

        else if (name == "ValkyrieInfusedArmor" && player.GetComponentInChildren<ArmorManager>().whichArmorIsEquipped == "ValkyrieInfusedArmor")
        {
            player.GetComponentInChildren<ArmorManager>().whichArmorIsEquipped = "Unarmored";
        }

        else if (name == "MuspelheimArmor" && player.GetComponentInChildren<ArmorManager>().whichArmorIsEquipped == "MuspelheimArmor")
        {
            player.GetComponentInChildren<ArmorManager>().whichArmorIsEquipped = "Unarmored";
        }

        else if (name == "AlfheimArmor" && player.GetComponentInChildren<ArmorManager>().whichArmorIsEquipped == "AlfheimArmor")
        {
            player.GetComponentInChildren<ArmorManager>().whichArmorIsEquipped = "Unarmored";
        }

        else if (name == "NiflheimArmor" && player.GetComponentInChildren<ArmorManager>().whichArmorIsEquipped == "NiflheimArmor")
        {
            player.GetComponentInChildren<ArmorManager>().whichArmorIsEquipped = "Unarmored";
        }

        else if (name == "MidgardArmor" && player.GetComponentInChildren<ArmorManager>().whichArmorIsEquipped == "MidgardArmor")
        {
            player.GetComponentInChildren<ArmorManager>().whichArmorIsEquipped = "Unarmored";
        }

        else if (name == "AsgardArmor" && player.GetComponentInChildren<ArmorManager>().whichArmorIsEquipped == "AsgardArmor")
        {
            player.GetComponentInChildren<ArmorManager>().whichArmorIsEquipped = "Unarmored";
        }

        else if (name == "JotunheimArmor" && player.GetComponentInChildren<ArmorManager>().whichArmorIsEquipped == "JotunheimArmor")
        {
            player.GetComponentInChildren<ArmorManager>().whichArmorIsEquipped = "Unarmored";
        }

        else if (name == "VanaheimArmor" && player.GetComponentInChildren<ArmorManager>().whichArmorIsEquipped == "VanaheimArmor")
        {
            player.GetComponentInChildren<ArmorManager>().whichArmorIsEquipped = "Unarmored";
        }

        else if (name == "SvartalfheimArmor" && player.GetComponentInChildren<ArmorManager>().whichArmorIsEquipped == "SvartalfheimArmor")
        {
            player.GetComponentInChildren<ArmorManager>().whichArmorIsEquipped = "Unarmored";
        }

        else if (name == "HelheimArmor" && player.GetComponentInChildren<ArmorManager>().whichArmorIsEquipped == "HelheimArmor")
        {
            player.GetComponentInChildren<ArmorManager>().whichArmorIsEquipped = "Unarmored";
        }

        else if (name == "DoomGuyArmor" && player.GetComponentInChildren<ArmorManager>().whichArmorIsEquipped == "DoomGuyArmor")
        {
            player.GetComponentInChildren<ArmorManager>().whichArmorIsEquipped = "Unarmored";
        }

        else if (name == "Stormtrooperarmor" && player.GetComponentInChildren<ArmorManager>().whichArmorIsEquipped == "Stormtrooperarmor")
        {
            player.GetComponentInChildren<ArmorManager>().whichArmorIsEquipped = "Unarmored";
        }

        else if (name == "GalaxyGlove" && player.GetComponentInChildren<ArmorManager>().whichArmorIsEquipped == "GalaxyGlove")
        {
            player.GetComponentInChildren<ArmorManager>().whichArmorIsEquipped = "Unarmored";
        }

        else
        {
            player.GetComponentInChildren<ArmorManager>().whichArmorIsEquipped = name;
        }
    }

    public void Update()
    {

    }
}
