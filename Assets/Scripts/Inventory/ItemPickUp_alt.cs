using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemPickUp_alt : MonoBehaviour
{
    public Item item;

    public GameObject player;
    public GameObject armor_arm;

    //materials for all the armors

    /*
    public Material LeatherArmorMat;
    public Material BoardHideArmorMat;
    public Material WolfSkinArmorMat;
    public Material ChainmailArmorMat;
    public Material AncientArmorMat;
    public Material RunicArmorMat;
    public Material SlaughterersArmorMat;
    public Material MithrilArmorMat;
    public Material ValkyrieInfusedArmorMat;
    public Material MuspelheimArmorMat;
    public Material AlfheimArmorMat;
    public Material NiflheimArmorMat;
    public Material MidgardArmorMat;
    public Material AsgardArmorMat;
    public Material JotunheimArmorMat;
    public Material VanaheimArmorMat;
    public Material SvartalfheimArmorMat;
    public Material HelheimArmorMat;
    public Material DoomGuyArmor;
    public Material StormtrooperArmor;
    public Material GalaxyGlove;
    */

    public void Start()
    {
        //not yet working, so I just commented it out

        /*
        player = GameObject.Find("Player");

        if (item.itemName == "LeatherArmor")
        {
            armor_arm.GetComponent<MeshRenderer>().material = LeatherArmorMat;
        }

        else if (item.itemName == "BoarHideArmor")
        {
            armor_arm.GetComponent<MeshRenderer>().material = BoardHideArmorMat;
        }

        else if (item.itemName == "WolfSkinArmor")
        {
            armor_arm.GetComponent<MeshRenderer>().material = WolfSkinArmorMat;
        }

        else if (item.itemName == "ChainmailArmor")
        {
            armor_arm.GetComponent<MeshRenderer>().material = ChainmailArmorMat;
        }

        else if (item.itemName == "AncientArmor")
        {
            armor_arm.GetComponent<MeshRenderer>().material = AncientArmorMat;
        }

        else if (item.itemName == "RunicArmor")
        {
            armor_arm.GetComponent<MeshRenderer>().material = RunicArmorMat;
        }

        else if (item.itemName == "SlaughterersArmor")
        {
            armor_arm.GetComponent<MeshRenderer>().material = SlaughterersArmorMat;
        }

        else if (item.itemName == "MithrilArmor")
        {
            armor_arm.GetComponent<MeshRenderer>().material = MithrilArmorMat;
        }

        else if (item.itemName == "ValkyrieInfusedArmor")
        {
            armor_arm.GetComponent<MeshRenderer>().material = ValkyrieInfusedArmorMat;
        }

        else if (item.itemName == "MuspelheimArmor")
        {
            armor_arm.GetComponent<MeshRenderer>().material = MuspelheimArmorMat;
        }

        else if (item.itemName == "AlfheimArmor")
        {
            armor_arm.GetComponent<MeshRenderer>().material = AlfheimArmorMat;
        }

        else if (item.itemName == "NiflheimArmor")
        {
            armor_arm.GetComponent<MeshRenderer>().material = NiflheimArmorMat;
        }

        else if (item.itemName == "MidgardArmor")
        {
            armor_arm.GetComponent<MeshRenderer>().material = MidgardArmorMat;
        }

        else if (item.itemName == "AsgardArmor")
        {
            armor_arm.GetComponent<MeshRenderer>().material = AsgardArmorMat;
        }

        else if (item.itemName == "JotunheimArmor")
        {
            armor_arm.GetComponent<MeshRenderer>().material = JotunheimArmorMat;
        }

        else if (item.itemName == "VanaheimArmor")
        {
            armor_arm.GetComponent<MeshRenderer>().material = VanaheimArmorMat;
        }

        else if (item.itemName == "SvartalfheimArmor")
        {
            armor_arm.GetComponent<MeshRenderer>().material = SvartalfheimArmorMat;
        }

        else if (item.itemName == "HelheimArmor")
        {
            armor_arm.GetComponent<MeshRenderer>().material = HelheimArmorMat;
        }

        else if (item.itemName == "DoomGuyArmor")
        {
            armor_arm.GetComponent<MeshRenderer>().material = DoomGuyArmor;
        }

        else if (item.itemName == "Stormtrooperarmor")
        {
            armor_arm.GetComponent<MeshRenderer>().material = StormtrooperArmor;
        }

        else if (item.itemName == "GalaxyGlove")
        {
            armor_arm.GetComponent<MeshRenderer>().material = GalaxyGlove;
        }
        */
    }

    public void Update()
    {

    }

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
