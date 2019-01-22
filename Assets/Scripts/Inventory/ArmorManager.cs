using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArmorManager : MonoBehaviour
{
    [Header("Check which Armor is currently equipped")]
    [Tooltip("String which reads out which Armor is equipped - gets set through the Inventory and Equip-Button-Press")]
    public string whichArmorIsEquipped;

    //enum for all the armor states possible (also containing having no armor)
    public enum Armors
    {
        Base,
        LeatherArmor,
        BoarHideArmor,
        WolfSkinArmor,
        ChainmailArmor,
        AncientArmor,
        RunicArmor,
        SlaughterersArmor,
        MithrilArmor,
        ValkyrieInfusedArmor,
        MuspelheimArmor,
        AlfheimArmor,
        NiflheimArmor,
        MidgardArmor,
        AsgardArmor,
        JotunheimArmor,
        VanaheimArmor,
        SvartalfheimArmor,
        HelheimArmor,
        DoomGuyArmor,
        StormtrooperArmor,
        GalaxyGlove
    }

    [Header("Materials for all the Armors")]
    public Material BaseMat;
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

    [Header("Meshes for the Hands")]
    [Tooltip("Object of the Left Hand (for changing its State/Material)")]
    public GameObject LeftHand;
    [Tooltip("Object of the Right Hand (for changing its State/Material)")]
    public GameObject RightHand;

    //setting the current armor to unarmored
    public Armors currentSlot = Armors.Base;

    public static WeaponSwitch Instance;

    public Armors CurrentSlot
    {
        get
        {
            return currentSlot;
        }
    }

    public void Start()
    {
        //setting the current armor to unarmored
        currentSlot = Armors.Base;
    }

    //checks for all the different armors - if one applies, change the armor state to that and call the UpdateArmors function
    public void Update()
    {
        if (whichArmorIsEquipped == "Unarmored")
        {
            currentSlot = Armors.Base;
            UpdateArmors();
        }

        if (whichArmorIsEquipped == "LeatherArmor")
        {
            currentSlot = Armors.LeatherArmor;
            UpdateArmors();
        }

        if (whichArmorIsEquipped == "BoarHideArmor")
        {
            currentSlot = Armors.BoarHideArmor;
            UpdateArmors();
        }

        if (whichArmorIsEquipped == "WolfSkinArmor")
        {
            currentSlot = Armors.WolfSkinArmor;
            UpdateArmors();
        }

        if (whichArmorIsEquipped == "ChainmailArmor")
        {
            currentSlot = Armors.ChainmailArmor;
            UpdateArmors();
        }

        if (whichArmorIsEquipped == "AncientArmor")
        {
            currentSlot = Armors.AncientArmor;
            UpdateArmors();
        }

        if (whichArmorIsEquipped == "RunicArmor")
        {
            currentSlot = Armors.RunicArmor;
            UpdateArmors();
        }

        if (whichArmorIsEquipped == "SlaughterersArmor")
        {
            currentSlot = Armors.SlaughterersArmor;
            UpdateArmors();
        }

        if (whichArmorIsEquipped == "MithrilArmor")
        {
            currentSlot = Armors.MithrilArmor;
            UpdateArmors();
        }

        if (whichArmorIsEquipped == "ValkyrieInfusedArmor")
        {
            currentSlot = Armors.ValkyrieInfusedArmor;
            UpdateArmors();
        }

        if (whichArmorIsEquipped == "MuspelheimArmor")
        {
            currentSlot = Armors.MuspelheimArmor;
            UpdateArmors();
        }

        if (whichArmorIsEquipped == "AlfheimArmor")
        {
            currentSlot = Armors.AlfheimArmor;
            UpdateArmors();
        }

        if (whichArmorIsEquipped == "NiflheimArmor")
        {
            currentSlot = Armors.NiflheimArmor;
            UpdateArmors();
        }

        if (whichArmorIsEquipped == "MidgardArmor")
        {
            currentSlot = Armors.MidgardArmor;
            UpdateArmors();
        }

        if (whichArmorIsEquipped == "AsgardArmor")
        {
            currentSlot = Armors.AsgardArmor;
            UpdateArmors();
        }

        if (whichArmorIsEquipped == "JotunheimArmor")
        {
            currentSlot = Armors.JotunheimArmor;
            UpdateArmors();
        }

        if (whichArmorIsEquipped == "VanaheimArmor")
        {
            currentSlot = Armors.VanaheimArmor;
            UpdateArmors();
        }

        if (whichArmorIsEquipped == "SvartalfheimArmor")
        {
            currentSlot = Armors.SvartalfheimArmor;
            UpdateArmors();
        }

        if (whichArmorIsEquipped == "HelheimArmor")
        {
            currentSlot = Armors.HelheimArmor;
            UpdateArmors();
        }

        if (whichArmorIsEquipped == "DoomGuyArmor")
        {
            currentSlot = Armors.DoomGuyArmor;
            UpdateArmors();
        }

        if (whichArmorIsEquipped == "StormtrooperArmor")
        {
            currentSlot = Armors.StormtrooperArmor;
            UpdateArmors();
        }

        if (whichArmorIsEquipped == "GalaxyGlove")
        {
            currentSlot = Armors.GalaxyGlove;
            UpdateArmors();
        }
    }

    /*
        function which gets called when an armor is being equipped
        this currently only changes the materials of the hand gameobjects to look accordingly
    */
    public void UpdateArmors()
    {
        if (currentSlot == Armors.Base)
        {
            LeftHand.GetComponent<MeshRenderer>().material = BaseMat;
            RightHand.GetComponent<MeshRenderer>().material = BaseMat;
        }

        if (currentSlot == Armors.LeatherArmor)
        {
            LeftHand.GetComponent<MeshRenderer>().material = LeatherArmorMat;
            RightHand.GetComponent<MeshRenderer>().material = LeatherArmorMat;
        }

        if (currentSlot == Armors.BoarHideArmor)
        {
            LeftHand.GetComponent<MeshRenderer>().material = BoardHideArmorMat;
            RightHand.GetComponent<MeshRenderer>().material = BoardHideArmorMat;
        }

        if (currentSlot == Armors.WolfSkinArmor)
        {
            LeftHand.GetComponent<MeshRenderer>().material = WolfSkinArmorMat;
            RightHand.GetComponent<MeshRenderer>().material = WolfSkinArmorMat;
        }

        if (currentSlot == Armors.ChainmailArmor)
        {
            LeftHand.GetComponent<MeshRenderer>().material = ChainmailArmorMat;
            RightHand.GetComponent<MeshRenderer>().material = ChainmailArmorMat;
        }

        if (currentSlot == Armors.AncientArmor)
        {
            LeftHand.GetComponent<MeshRenderer>().material = AncientArmorMat;
            RightHand.GetComponent<MeshRenderer>().material = AncientArmorMat;
        }

        if (currentSlot == Armors.RunicArmor)
        {
            LeftHand.GetComponent<MeshRenderer>().material = RunicArmorMat;
            RightHand.GetComponent<MeshRenderer>().material = RunicArmorMat;
        }

        if (currentSlot == Armors.SlaughterersArmor)
        {
            LeftHand.GetComponent<MeshRenderer>().material = SlaughterersArmorMat;
            RightHand.GetComponent<MeshRenderer>().material = SlaughterersArmorMat;
        }

        if (currentSlot == Armors.MithrilArmor)
        {
            LeftHand.GetComponent<MeshRenderer>().material = MithrilArmorMat;
            RightHand.GetComponent<MeshRenderer>().material = MithrilArmorMat;
        }

        if (currentSlot == Armors.ValkyrieInfusedArmor)
        {
            LeftHand.GetComponent<MeshRenderer>().material = ValkyrieInfusedArmorMat;
            RightHand.GetComponent<MeshRenderer>().material = ValkyrieInfusedArmorMat;
        }

        if (currentSlot == Armors.MuspelheimArmor)
        {
            LeftHand.GetComponent<MeshRenderer>().material = MuspelheimArmorMat;
            RightHand.GetComponent<MeshRenderer>().material = MuspelheimArmorMat;
        }

        if (currentSlot == Armors.AlfheimArmor)
        {
            LeftHand.GetComponent<MeshRenderer>().material = AlfheimArmorMat;
            RightHand.GetComponent<MeshRenderer>().material = AlfheimArmorMat;
        }

        if (currentSlot == Armors.NiflheimArmor)
        {
            LeftHand.GetComponent<MeshRenderer>().material = NiflheimArmorMat;
            RightHand.GetComponent<MeshRenderer>().material = NiflheimArmorMat;
        }

        if (currentSlot == Armors.MidgardArmor)
        {
            LeftHand.GetComponent<MeshRenderer>().material = MidgardArmorMat;
            RightHand.GetComponent<MeshRenderer>().material = MidgardArmorMat;
        }

        if (currentSlot == Armors.AsgardArmor)
        {
            LeftHand.GetComponent<MeshRenderer>().material = AsgardArmorMat;
            RightHand.GetComponent<MeshRenderer>().material = AsgardArmorMat;
        }

        if (currentSlot == Armors.JotunheimArmor)
        {
            LeftHand.GetComponent<MeshRenderer>().material = JotunheimArmorMat;
            RightHand.GetComponent<MeshRenderer>().material = JotunheimArmorMat;
        }

        if (currentSlot == Armors.VanaheimArmor)
        {
            LeftHand.GetComponent<MeshRenderer>().material = VanaheimArmorMat;
            RightHand.GetComponent<MeshRenderer>().material = VanaheimArmorMat;
        }

        if (currentSlot == Armors.SvartalfheimArmor)
        {
            LeftHand.GetComponent<MeshRenderer>().material = SvartalfheimArmorMat;
            RightHand.GetComponent<MeshRenderer>().material = SvartalfheimArmorMat;
        }

        if (currentSlot == Armors.HelheimArmor)
        {
            LeftHand.GetComponent<MeshRenderer>().material = HelheimArmorMat;
            RightHand.GetComponent<MeshRenderer>().material = HelheimArmorMat;
        }

        if (currentSlot == Armors.DoomGuyArmor)
        {
            LeftHand.GetComponent<MeshRenderer>().material = DoomGuyArmor;
            RightHand.GetComponent<MeshRenderer>().material = DoomGuyArmor;
        }

        if (currentSlot == Armors.StormtrooperArmor)
        {
            LeftHand.GetComponent<MeshRenderer>().material = StormtrooperArmor;
            RightHand.GetComponent<MeshRenderer>().material = StormtrooperArmor;
        }

        if (currentSlot == Armors.GalaxyGlove)
        {
            LeftHand.GetComponent<MeshRenderer>().material = GalaxyGlove;
            RightHand.GetComponent<MeshRenderer>().material = GalaxyGlove;
        }
    }
}