using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InventoryUI : MonoBehaviour
{
    private Color greyColor;
    private Color greenColor;
    private Color blueColor;
    private Color purpleColor;

    public Transform itemsParent;

    Inventory inventory;

    InventorySlot[] slots;

    public void Start()
    {
        inventory = Inventory.instance;
        inventory.onItemChangedCallback += UpdateUI;

        slots = itemsParent.GetComponentsInChildren<InventorySlot>();

        ColorUtility.TryParseHtmlString("#C8C8C8", out greyColor);
        ColorUtility.TryParseHtmlString("#6FC200", out greenColor);
        ColorUtility.TryParseHtmlString("#336DFF", out blueColor);
        ColorUtility.TryParseHtmlString("#AB55FF", out purpleColor);
    }

    public void Update()
    {
        
    }

    public void UpdateUI()
    {
        for (int i = 0; i < slots.Length; i++)
        {
            if (i < inventory.items.Count)
            {
                slots[i].AddItem(inventory.items[i]);
                slots[i].gameObject.SetActive(true);

                if (inventory.items[i].itemRarity == "Common")
                {
                    slots[i].transform.Find("ArmorBase").GetComponentInChildren<Image>().color = greyColor;
                    slots[i].transform.Find("RemoveButton").GetComponentInChildren<Image>().color = greyColor;
                    slots[i].transform.Find("EquipButton").GetComponentInChildren<Image>().color = greyColor;
                }

                if (inventory.items[i].itemRarity == "Uncommon")
                {
                    slots[i].transform.Find("ArmorBase").GetComponentInChildren<Image>().color = greenColor;
                    slots[i].transform.Find("RemoveButton").GetComponentInChildren<Image>().color = greenColor;
                    slots[i].transform.Find("EquipButton").GetComponentInChildren<Image>().color = greenColor;
                }

                if (inventory.items[i].itemRarity == "Rare")
                {
                    slots[i].transform.Find("ArmorBase").GetComponentInChildren<Image>().color = blueColor;
                    slots[i].transform.Find("RemoveButton").GetComponentInChildren<Image>().color = blueColor;
                    slots[i].transform.Find("EquipButton").GetComponentInChildren<Image>().color = blueColor;
                }

                if (inventory.items[i].itemRarity == "Legendary")
                {
                    slots[i].transform.Find("ArmorBase").GetComponentInChildren<Image>().color = purpleColor;
                    slots[i].transform.Find("RemoveButton").GetComponentInChildren<Image>().color = purpleColor;
                    slots[i].transform.Find("EquipButton").GetComponentInChildren<Image>().color = purpleColor;
                }
            }

            else
            {
                slots[i].ClearSlot();
                slots[i].gameObject.SetActive(false);
            }
        }
    }
}
