using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InventoryUI : MonoBehaviour
{
    public bool Scroll_Weapon_Triggered = false;
    public bool Scroll_Armor_Triggered = false;

    public GameObject Scroll_Weapon;
    public GameObject Scroll_Armor;

    public GameObject player;

    public ArmorManager armorManager;
    public Image armorIcon;
    public Image armorBG;
    public Text armorValueText;

    public Image HUD_Icon;
    public Image HUD_BG;

    public Sprite leatherArmor;
    public Sprite boarhideArmor;
    public Sprite wolfskinArmor;
    public Sprite chainmailArmor;
    public Sprite ancientArmor;
    public Sprite runicArmor;
    public Sprite slaughteresArmor;
    public Sprite mithrilArmor;
    public Sprite valkyrieinfusedArmor;
    public Sprite muspelheimArmor;
    public Sprite alfheimArmor;
    public Sprite niflheimArmor;
    public Sprite midgardArmor;
    public Sprite asgardArmor;
    public Sprite jotunheimArmor;
    public Sprite vanaheimArmor;
    public Sprite svartalfheimArmor;
    public Sprite helheimArmor;
    public Sprite doomguyArmor;
    public Sprite stormtrooperArmor;
    public Sprite galaxyGlove;

    //colors in case we want to switch back to the coloring method
    private Color greyColor;
    private Color greenColor;
    private Color blueColor;
    private Color purpleColor;
    private Color blackColor;

    //sprites for the item tiles - the way we do it right now
    public Sprite greySprite;
    public Sprite greenSprite;
    public Sprite blueSprite;
    public Sprite purpleSprite;

    //the GameObject which contains the prefab items
    public GameObject inventoryGameObject;

    //parent for the items
    public Transform itemsParent;

    //inventory integration
    Inventory inventory;

    //slots array
    InventorySlot[] slots;

    public void Start()
    {
        //singleton
        inventory = Inventory.instance;
        inventory.onItemChangedCallback += UpdateUI;

        //get slots object
        slots = itemsParent.GetComponentsInChildren<InventorySlot>();

        //set hexcodes for colors
        ColorUtility.TryParseHtmlString("#C8C8C8", out greyColor);
        ColorUtility.TryParseHtmlString("#61EF00", out greenColor);
        ColorUtility.TryParseHtmlString("#0080FF", out blueColor);
        ColorUtility.TryParseHtmlString("#BA44E3", out purpleColor);
        ColorUtility.TryParseHtmlString("#101010", out blackColor);
    }

    public void Update()
    {
        if (Scroll_Weapon_Triggered == true)
        {
            Scroll_Weapon.gameObject.SetActive(true);
            Scroll_Armor.gameObject.SetActive(false);
        }

        if (Scroll_Armor_Triggered == true)
        {
            Scroll_Armor.gameObject.SetActive(true);
            Scroll_Weapon.gameObject.SetActive(false);
        }

        if (Scroll_Weapon_Triggered == false && Scroll_Armor_Triggered == false)
        {
            Scroll_Weapon.gameObject.SetActive(false);
            Scroll_Armor.gameObject.SetActive(false);
        }

        if (armorManager.whichArmorIsEquipped == "Unarmored")
        {
            armorIcon.sprite = null;
            armorIcon.color = blackColor;
            armorBG.color = blackColor;

            HUD_Icon.sprite = null;
            HUD_Icon.color = blackColor;
            HUD_BG.color = blackColor;

            armorValueText.text = "0";
        }

        if (armorManager.whichArmorIsEquipped == "LeatherArmor")
        {
            armorIcon.sprite = leatherArmor;
            armorIcon.color = Color.white;
            armorBG.color = greyColor;

            HUD_Icon.sprite = leatherArmor;
            HUD_Icon.color = Color.white;
            HUD_BG.color = greyColor;

            armorValueText.text = "5";
        }

        if (armorManager.whichArmorIsEquipped == "BoarHideArmor")
        {
            armorIcon.sprite = boarhideArmor;
            armorIcon.color = Color.white;
            armorBG.color = greyColor;

            HUD_Icon.sprite = boarhideArmor;
            HUD_Icon.color = Color.white;
            HUD_BG.color = greyColor;

            armorValueText.text = "7";
        }

        if (armorManager.whichArmorIsEquipped == "WolfSkinArmor")
        {
            armorIcon.sprite = wolfskinArmor;
            armorIcon.color = Color.white;
            armorBG.color = greyColor;

            HUD_Icon.sprite = wolfskinArmor;
            HUD_Icon.color = Color.white;
            HUD_BG.color = greyColor;

            armorValueText.text = "8";
        }

        if (armorManager.whichArmorIsEquipped == "ChainmailArmor")
        {
            armorIcon.sprite = chainmailArmor;
            armorIcon.color = Color.white;
            armorBG.color = greenColor;

            HUD_Icon.sprite = chainmailArmor;
            HUD_Icon.color = Color.white;
            HUD_BG.color = greenColor;

            armorValueText.text = "18";
        }

        if (armorManager.whichArmorIsEquipped == "AncientArmor")
        {
            armorIcon.sprite = ancientArmor;
            armorIcon.color = Color.white;
            armorBG.color = greenColor;

            HUD_Icon.sprite = ancientArmor;
            HUD_Icon.color = Color.white;
            HUD_BG.color = greenColor;

            armorValueText.text = "21";
        }

        if (armorManager.whichArmorIsEquipped == "RunicArmor")
        {
            armorIcon.sprite = runicArmor;
            armorIcon.color = Color.white;
            armorBG.color = greenColor;

            HUD_Icon.sprite = runicArmor;
            HUD_Icon.color = Color.white;
            HUD_BG.color = greenColor;

            armorValueText.text = "25";
        }

        if (armorManager.whichArmorIsEquipped == "SlaughterersArmor")
        {
            armorIcon.sprite = slaughteresArmor;
            armorIcon.color = Color.white;
            armorBG.color = blueColor;

            HUD_Icon.sprite = slaughteresArmor;
            HUD_Icon.color = Color.white;
            HUD_BG.color = blueColor;

            armorValueText.text = "50";
        }

        if (armorManager.whichArmorIsEquipped == "MithrilArmor")
        {
            armorIcon.sprite = mithrilArmor;
            armorIcon.color = Color.white;
            armorBG.color = blueColor;

            HUD_Icon.sprite = mithrilArmor;
            HUD_Icon.color = Color.white;
            HUD_BG.color = blueColor;

            armorValueText.text = "52";
        }

        if (armorManager.whichArmorIsEquipped == "ValkyrieInfusedArmor")
        {
            armorIcon.sprite = valkyrieinfusedArmor;
            armorIcon.color = Color.white;
            armorBG.color = blueColor;

            HUD_Icon.sprite = valkyrieinfusedArmor;
            HUD_Icon.color = Color.white;
            HUD_BG.color = blueColor;

            armorValueText.text = "59";
        }

        if (armorManager.whichArmorIsEquipped == "MuspelheimArmor")
        {
            armorIcon.sprite = muspelheimArmor;
            armorIcon.color = Color.white;
            armorBG.color = purpleColor;

            HUD_Icon.sprite = muspelheimArmor;
            HUD_Icon.color = Color.white;
            HUD_BG.color = purpleColor;

            armorValueText.text = "96";
        }

        if (armorManager.whichArmorIsEquipped == "AlfheimArmor")
        {
            armorIcon.sprite = alfheimArmor;
            armorIcon.color = Color.white;
            armorBG.color = purpleColor;

            HUD_Icon.sprite = alfheimArmor;
            HUD_Icon.color = Color.white;
            HUD_BG.color = purpleColor;

            armorValueText.text = "86";
        }

        if (armorManager.whichArmorIsEquipped == "NiflheimArmor")
        {
            armorIcon.sprite = niflheimArmor;
            armorIcon.color = Color.white;
            armorBG.color = purpleColor;

            HUD_Icon.sprite = niflheimArmor;
            HUD_Icon.color = Color.white;
            HUD_BG.color = purpleColor;

            armorValueText.text = "95";
        }

        if (armorManager.whichArmorIsEquipped == "MidgardArmor")
        {
            armorIcon.sprite = midgardArmor;
            armorIcon.color = Color.white;
            armorBG.color = purpleColor;

            HUD_Icon.sprite = midgardArmor;
            HUD_Icon.color = Color.white;
            HUD_BG.color = purpleColor;

            armorValueText.text = "89";
        }

        if (armorManager.whichArmorIsEquipped == "AsgardArmor")
        {
            armorIcon.sprite = asgardArmor;
            armorIcon.color = Color.white;
            armorBG.color = purpleColor;

            HUD_Icon.sprite = asgardArmor;
            HUD_Icon.color = Color.white;
            HUD_BG.color = purpleColor;

            armorValueText.text = "88";
        }

        if (armorManager.whichArmorIsEquipped == "JotunheimArmor")
        {
            armorIcon.sprite = jotunheimArmor;
            armorIcon.color = Color.white;
            armorBG.color = purpleColor;

            HUD_Icon.sprite = jotunheimArmor;
            HUD_Icon.color = Color.white;
            HUD_BG.color = purpleColor;

            armorValueText.text = "91";
        }

        if (armorManager.whichArmorIsEquipped == "VanaheimArmor")
        {
            armorIcon.sprite = vanaheimArmor;
            armorIcon.color = Color.white;
            armorBG.color = purpleColor;

            HUD_Icon.sprite = vanaheimArmor;
            HUD_Icon.color = Color.white;
            HUD_BG.color = purpleColor;

            armorValueText.text = "90";
        }

        if (armorManager.whichArmorIsEquipped == "SvartalfheimArmor")
        {
            armorIcon.sprite = svartalfheimArmor;
            armorIcon.color = Color.white;
            armorBG.color = purpleColor;

            HUD_Icon.sprite = svartalfheimArmor;
            HUD_Icon.color = Color.white;
            HUD_BG.color = purpleColor;

            armorValueText.text = "89";
        }

        if (armorManager.whichArmorIsEquipped == "HelheimArmor")
        {
            armorIcon.sprite = helheimArmor;
            armorIcon.color = Color.white;
            armorBG.color = purpleColor;

            HUD_Icon.sprite = helheimArmor;
            HUD_Icon.color = Color.white;
            HUD_BG.color = purpleColor;

            armorValueText.text = "100";
        }

        if (armorManager.whichArmorIsEquipped == "DoomGuyArmor")
        {
            armorIcon.sprite = doomguyArmor;
            armorIcon.color = Color.white;
            armorBG.color = greenColor;

            HUD_Icon.sprite = doomguyArmor;
            HUD_Icon.color = Color.white;
            HUD_BG.color = greenColor;

            armorValueText.text = "66";
        }

        if (armorManager.whichArmorIsEquipped == "StormtrooperArmor")
        {
            armorIcon.sprite = stormtrooperArmor;
            armorIcon.color = Color.white;
            armorBG.color = greenColor;

            HUD_Icon.sprite = stormtrooperArmor;
            HUD_Icon.color = Color.white;
            HUD_BG.color = greenColor;

            armorValueText.text = "21";
        }

        if (armorManager.whichArmorIsEquipped == "GalaxyGlove")
        {
            armorIcon.sprite = galaxyGlove;
            armorIcon.color = Color.white;
            armorBG.color = purpleColor;

            HUD_Icon.sprite = galaxyGlove;
            HUD_Icon.color = Color.white;
            HUD_BG.color = purpleColor;

            armorValueText.text = "100";
        }
    }

    //updateUI function - gets called every time an item gets added or removed
    public void UpdateUI()
    {
        //set GameObject which contains prefab slots to true
        inventoryGameObject.gameObject.SetActive(true);

        //loop for every slots
        for (int i = 0; i < slots.Length; i++)
        {
            if (i < inventory.items.Count)
            {
                //on addition of item - add the according item to the slot and set the slot to active
                slots[i].AddItem(inventory.items[i]);
                slots[i].gameObject.SetActive(true);

                //set sprite for 'common' tagged item
                if (inventory.items[i].itemRarity == "Common")
                {
                    //slots[i].transform.Find("ArmorBase").GetComponentInChildren<Image>().sprite = greySprite;
                    slots[i].transform.Find("ArmorBase").GetComponentInChildren<Image>().color = greyColor;
                }

                //set sprite for 'uncommon' tagged item
                if (inventory.items[i].itemRarity == "Uncommon")
                {
                    //slots[i].transform.Find("ArmorBase").GetComponentInChildren<Image>().sprite = greenSprite;
                    slots[i].transform.Find("ArmorBase").GetComponentInChildren<Image>().color = greenColor;
                }

                //set sprite for 'rare' tagged item
                if (inventory.items[i].itemRarity == "Rare")
                {
                    //slots[i].transform.Find("ArmorBase").GetComponentInChildren<Image>().sprite = blueSprite;
                    slots[i].transform.Find("ArmorBase").GetComponentInChildren<Image>().color = blueColor;
                }


                //set sprite for 'legendary' tagged item
                if (inventory.items[i].itemRarity == "Legendary")
                {
                    //slots[i].transform.Find("ArmorBase").GetComponentInChildren<Image>().sprite = purpleSprite;
                    slots[i].transform.Find("ArmorBase").GetComponentInChildren<Image>().color = purpleColor;
                }
            }

            else
            {
                //on removal of item - clear the slot and set the slot to inactive
                slots[i].ClearSlot();
                slots[i].gameObject.SetActive(false);
            }
        }
    }

    public void UnEquipArmor()
    {
        if (player.GetComponentInChildren<ArmorManager>().whichArmorIsEquipped == "LeatherArmor")
        {
            player.GetComponentInChildren<ArmorManager>().whichArmorIsEquipped = "Unarmored";
        }

        else if (player.GetComponentInChildren<ArmorManager>().whichArmorIsEquipped == "BoarHideArmor")
        {
            player.GetComponentInChildren<ArmorManager>().whichArmorIsEquipped = "Unarmored";
        }

        else if (player.GetComponentInChildren<ArmorManager>().whichArmorIsEquipped == "WolfSkinArmor")
        {
            player.GetComponentInChildren<ArmorManager>().whichArmorIsEquipped = "Unarmored";
        }

        else if (player.GetComponentInChildren<ArmorManager>().whichArmorIsEquipped == "ChainmailArmor")
        {
            player.GetComponentInChildren<ArmorManager>().whichArmorIsEquipped = "Unarmored";
        }

        else if (player.GetComponentInChildren<ArmorManager>().whichArmorIsEquipped == "AncientArmor")
        {
            player.GetComponentInChildren<ArmorManager>().whichArmorIsEquipped = "Unarmored";
        }

        else if (player.GetComponentInChildren<ArmorManager>().whichArmorIsEquipped == "RunicArmor")
        {
            player.GetComponentInChildren<ArmorManager>().whichArmorIsEquipped = "Unarmored";
        }

        else if (player.GetComponentInChildren<ArmorManager>().whichArmorIsEquipped == "SlaughterersArmor")
        {
            player.GetComponentInChildren<ArmorManager>().whichArmorIsEquipped = "Unarmored";
        }

        else if (player.GetComponentInChildren<ArmorManager>().whichArmorIsEquipped == "MithrilArmor")
        {
            player.GetComponentInChildren<ArmorManager>().whichArmorIsEquipped = "Unarmored";
        }

        else if (player.GetComponentInChildren<ArmorManager>().whichArmorIsEquipped == "ValkyrieInfusedArmor")
        {
            player.GetComponentInChildren<ArmorManager>().whichArmorIsEquipped = "Unarmored";
        }

        else if (player.GetComponentInChildren<ArmorManager>().whichArmorIsEquipped == "MuspelheimArmor")
        {
            player.GetComponentInChildren<ArmorManager>().whichArmorIsEquipped = "Unarmored";
        }

        else if (player.GetComponentInChildren<ArmorManager>().whichArmorIsEquipped == "AlfheimArmor")
        {
            player.GetComponentInChildren<ArmorManager>().whichArmorIsEquipped = "Unarmored";
        }

        else if (player.GetComponentInChildren<ArmorManager>().whichArmorIsEquipped == "NiflheimArmor")
        {
            player.GetComponentInChildren<ArmorManager>().whichArmorIsEquipped = "Unarmored";
        }

        else if (player.GetComponentInChildren<ArmorManager>().whichArmorIsEquipped == "MidgardArmor")
        {
            player.GetComponentInChildren<ArmorManager>().whichArmorIsEquipped = "Unarmored";
        }

        else if (player.GetComponentInChildren<ArmorManager>().whichArmorIsEquipped == "AsgardArmor")
        {
            player.GetComponentInChildren<ArmorManager>().whichArmorIsEquipped = "Unarmored";
        }

        else if (player.GetComponentInChildren<ArmorManager>().whichArmorIsEquipped == "JotunheimArmor")
        {
            player.GetComponentInChildren<ArmorManager>().whichArmorIsEquipped = "Unarmored";
        }

        else if (player.GetComponentInChildren<ArmorManager>().whichArmorIsEquipped == "VanaheimArmor")
        {
            player.GetComponentInChildren<ArmorManager>().whichArmorIsEquipped = "Unarmored";
        }

        else if (player.GetComponentInChildren<ArmorManager>().whichArmorIsEquipped == "SvartalfheimArmor")
        {
            player.GetComponentInChildren<ArmorManager>().whichArmorIsEquipped = "Unarmored";
        }

            else if (player.GetComponentInChildren<ArmorManager>().whichArmorIsEquipped == "HelheimArmor")
        {
            player.GetComponentInChildren<ArmorManager>().whichArmorIsEquipped = "Unarmored";
        }

        else if (player.GetComponentInChildren<ArmorManager>().whichArmorIsEquipped == "DoomGuyArmor")
        {
            player.GetComponentInChildren<ArmorManager>().whichArmorIsEquipped = "Unarmored";
        }

        else if (player.GetComponentInChildren<ArmorManager>().whichArmorIsEquipped == "Stormtrooperarmor")
        {
            player.GetComponentInChildren<ArmorManager>().whichArmorIsEquipped = "Unarmored";
        }

        else if (player.GetComponentInChildren<ArmorManager>().whichArmorIsEquipped == "GalaxyGlove")
        {
            player.GetComponentInChildren<ArmorManager>().whichArmorIsEquipped = "Unarmored";
        }
    }

    public void LeftHandButton_Click()
    {
        if (Scroll_Weapon_Triggered == false)
        {
            Scroll_Weapon_Triggered = true;
        }

        else if (Scroll_Weapon_Triggered == true)
        {
            Scroll_Weapon_Triggered = false;
        }
    }

    public void RightHandButton_Click()
    {
        if (Scroll_Weapon_Triggered == false)
        {
            Scroll_Weapon_Triggered = true;
        }

        else if (Scroll_Weapon_Triggered == true)
        {
            Scroll_Weapon_Triggered = false;
        }
    }

    public void ArmorButton_Click()
    {
        if (Scroll_Armor_Triggered == false)
        {
            Scroll_Armor_Triggered = true;
        }

        else if (Scroll_Armor_Triggered == true)
        {
            Scroll_Armor_Triggered = false;
        }
    }
}
