using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InventoryUI : MonoBehaviour
{
    //colors in case we want to switch back to the coloring method
    private Color greyColor;
    private Color greenColor;
    private Color blueColor;
    private Color purpleColor;

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
    }

    public void Update()
    {
        
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
                    slots[i].transform.Find("ArmorBase").GetComponentInChildren<Image>().sprite = greySprite;
                }

                //set sprite for 'uncommon' tagged item
                if (inventory.items[i].itemRarity == "Uncommon")
                {
                    slots[i].transform.Find("ArmorBase").GetComponentInChildren<Image>().sprite = greenSprite;
                }

                //set sprite for 'rare' tagged item
                if (inventory.items[i].itemRarity == "Rare")
                {
                    slots[i].transform.Find("ArmorBase").GetComponentInChildren<Image>().sprite = blueSprite;
                }


                //set sprite for 'legendary' tagged item
                if (inventory.items[i].itemRarity == "Legendary")
                {
                    slots[i].transform.Find("ArmorBase").GetComponentInChildren<Image>().sprite = purpleSprite;
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
}
