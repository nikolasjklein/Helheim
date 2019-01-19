using UnityEngine;
using UnityEngine.UI;

public class InventorySlot : MonoBehaviour
{
    //containments of the item slot
    public Image itemIcon;
    //public Text itemName;
    //public Text itemRarity;
    //public Text itemValue;

    //scriptable object integration
    Item item;

    //function to add item
    public void AddItem(Item newItem)
    {
        item = newItem;

        //set the items sprite to the icon and enable the icon
        itemIcon.sprite = item.itemIcon;
        itemIcon.enabled = true;

        //set the items name to the text and enable the text
        //itemName.text = item.itemName;
        //itemName.enabled = true;

        //set the items rarity to the text and enable the text
        //itemRarity.text = item.itemRarity;
        //itemRarity.enabled = true;

        //set the items value to the text and enable the text
        //itemValue.text = item.armorDefense.ToString();
        //itemValue.enabled = true;
    }

    //function to clear the slot
    public void ClearSlot()
    {
        //set the item to null
        item = null;

        //clear the item icon and disable it
        itemIcon.sprite = null;
        itemIcon.enabled = false;

        //clear the name text and disable it
        //itemName.text = null;
        //itemName.enabled = false;

        //clear the rarity text and disable it
        //itemRarity.text = null;
        //itemRarity.enabled = false;

        //clear the value text and disable it
        //itemValue.text = null;
        //itemValue.enabled = false;
    }

    //function which is linked to the remove-button-press
    public void OnRemoveButton()
    {
        //remove item
        Inventory.instance.Remove(item);
    }

    //function which is linked to the equip-button-press
    public void UseItem()
    {
        if (item != null)
        {
            //call use-function in the item class
            item.Use();
        }
    }
}
