using UnityEngine;
using UnityEngine.UI;

public class InventorySlot : MonoBehaviour
{
    public Image itemIcon;
    public Text itemName;
    public Text itemRarity;
    public Text itemValue;

    Item item;

    public void AddItem(Item newItem)
    {
        item = newItem;

        itemIcon.sprite = item.itemIcon;
        itemIcon.enabled = true;

        itemName.text = item.itemName;
        itemName.enabled = true;

        itemRarity.text = item.itemRarity;
        itemRarity.enabled = true;

        itemValue.text = item.armorDefense.ToString();
        itemValue.enabled = true;
    }

    public void ClearSlot()
    {
        item = null;

        itemIcon.sprite = null;
        itemIcon.enabled = false;

        itemName.text = null;
        itemName.enabled = false;

        itemRarity.text = null;
        itemRarity.enabled = false;

        itemValue.text = null;
        itemValue.enabled = false;
    }

    public void OnRemoveButton()
    {
        Inventory.instance.Remove(item);
    }

    public void UseItem()
    {
        if (item != null)
        {
            item.Use();
        }
    }
}
