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

    public Sprite greySprite;
    public Sprite greenSprite;
    public Sprite blueSprite;
    public Sprite purpleSprite;

    public Transform itemsParent;

    Inventory inventory;

    InventorySlot[] slots;

    public void Start()
    {
        inventory = Inventory.instance;
        inventory.onItemChangedCallback += UpdateUI;

        slots = itemsParent.GetComponentsInChildren<InventorySlot>();

        ColorUtility.TryParseHtmlString("#C8C8C8", out greyColor);
        ColorUtility.TryParseHtmlString("#61EF00", out greenColor);
        ColorUtility.TryParseHtmlString("#0080FF", out blueColor);
        ColorUtility.TryParseHtmlString("#BA44E3", out purpleColor);
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
                    slots[i].transform.Find("ArmorBase").GetComponentInChildren<Image>().sprite = greySprite;
                }

                if (inventory.items[i].itemRarity == "Uncommon")
                {
                    slots[i].transform.Find("ArmorBase").GetComponentInChildren<Image>().sprite = greenSprite;
                }

                if (inventory.items[i].itemRarity == "Rare")
                {
                    slots[i].transform.Find("ArmorBase").GetComponentInChildren<Image>().sprite = blueSprite;
                }

                if (inventory.items[i].itemRarity == "Legendary")
                {
                    slots[i].transform.Find("ArmorBase").GetComponentInChildren<Image>().sprite = purpleSprite;
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
