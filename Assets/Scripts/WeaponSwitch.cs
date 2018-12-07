using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WeaponSwitch : MonoBehaviour
{
    public enum InventorySlots
    {
        Zero,
        One,
        Two,
        Three,
        Four,
        Five,
        Six,
        Seven,
        Eight,
        Nine
    }

    public Text inventorySlotText;

    public GameObject slot_0;
    public GameObject slot_1;
    public GameObject slot_2;
    public GameObject slot_3;
    public GameObject slot_4;
    public GameObject slot_5;
    public GameObject slot_6;
    public GameObject slot_7;
    public GameObject slot_8;
    public GameObject slot_9;

    public InventorySlots currentSlot = InventorySlots.Zero;

    public static WeaponSwitch Instance;

    public InventorySlots CurrentSlot
    {
        get
        {
            return currentSlot;
        }
    }

    public void Start()
    {
        currentSlot = InventorySlots.Zero;
        inventorySlotText.text = "0 - Hands";
        slot_0.gameObject.SetActive(true);
        slot_1.gameObject.SetActive(false);
        slot_2.gameObject.SetActive(false);
        slot_3.gameObject.SetActive(false);
        slot_4.gameObject.SetActive(false);
        slot_5.gameObject.SetActive(false);
        slot_6.gameObject.SetActive(false);
        slot_7.gameObject.SetActive(false);
        slot_8.gameObject.SetActive(false);
        slot_9.gameObject.SetActive(false);
    }

    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha0))
        {
            currentSlot = InventorySlots.Zero;
            inventorySlotText.text = "0 - Hands";
            slot_0.gameObject.SetActive(true);
            slot_1.gameObject.SetActive(false);
            slot_2.gameObject.SetActive(false);
            slot_3.gameObject.SetActive(false);
            slot_4.gameObject.SetActive(false);
            slot_5.gameObject.SetActive(false);
            slot_6.gameObject.SetActive(false);
            slot_7.gameObject.SetActive(false);
            slot_8.gameObject.SetActive(false);
            slot_9.gameObject.SetActive(false);
        }

        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            currentSlot = InventorySlots.One;
            inventorySlotText.text = "1 - Sword&Shield";
            slot_0.gameObject.SetActive(false);
            slot_1.gameObject.SetActive(true);
            slot_2.gameObject.SetActive(false);
            slot_3.gameObject.SetActive(false);
            slot_4.gameObject.SetActive(false);
            slot_5.gameObject.SetActive(false);
            slot_6.gameObject.SetActive(false);
            slot_7.gameObject.SetActive(false);
            slot_8.gameObject.SetActive(false);
            slot_9.gameObject.SetActive(false);
        }

        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            currentSlot = InventorySlots.Two;
            inventorySlotText.text = "2 - Bolt Rifle";
            slot_0.gameObject.SetActive(false);
            slot_1.gameObject.SetActive(false);
            slot_2.gameObject.SetActive(true);
            slot_3.gameObject.SetActive(false);
            slot_4.gameObject.SetActive(false);
            slot_5.gameObject.SetActive(false);
            slot_6.gameObject.SetActive(false);
            slot_7.gameObject.SetActive(false);
            slot_8.gameObject.SetActive(false);
            slot_9.gameObject.SetActive(false);
        }

        if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            currentSlot = InventorySlots.Three;
            inventorySlotText.text = "3 - Repeating Crossbow";
            slot_0.gameObject.SetActive(false);
            slot_1.gameObject.SetActive(false);
            slot_2.gameObject.SetActive(false);
            slot_3.gameObject.SetActive(true);
            slot_4.gameObject.SetActive(false);
            slot_5.gameObject.SetActive(false);
            slot_6.gameObject.SetActive(false);
            slot_7.gameObject.SetActive(false);
            slot_8.gameObject.SetActive(false);
            slot_9.gameObject.SetActive(false);
        }

        if (Input.GetKeyDown(KeyCode.Alpha4))
        {
            currentSlot = InventorySlots.Four;
            inventorySlotText.text = "4";
            slot_0.gameObject.SetActive(false);
            slot_1.gameObject.SetActive(false);
            slot_2.gameObject.SetActive(false);
            slot_3.gameObject.SetActive(false);
            slot_4.gameObject.SetActive(true);
            slot_5.gameObject.SetActive(false);
            slot_6.gameObject.SetActive(false);
            slot_7.gameObject.SetActive(false);
            slot_8.gameObject.SetActive(false);
            slot_9.gameObject.SetActive(false);
        }

        if (Input.GetKeyDown(KeyCode.Alpha5))
        {
            currentSlot = InventorySlots.Five;
            inventorySlotText.text = "5";
            slot_0.gameObject.SetActive(false);
            slot_1.gameObject.SetActive(false);
            slot_2.gameObject.SetActive(false);
            slot_3.gameObject.SetActive(false);
            slot_4.gameObject.SetActive(false);
            slot_5.gameObject.SetActive(true);
            slot_6.gameObject.SetActive(false);
            slot_7.gameObject.SetActive(false);
            slot_8.gameObject.SetActive(false);
            slot_9.gameObject.SetActive(false);
        }

        if (Input.GetKeyDown(KeyCode.Alpha6))
        {
            currentSlot = InventorySlots.Six;
            inventorySlotText.text = "6";
            slot_0.gameObject.SetActive(false);
            slot_1.gameObject.SetActive(false);
            slot_2.gameObject.SetActive(false);
            slot_3.gameObject.SetActive(false);
            slot_4.gameObject.SetActive(false);
            slot_5.gameObject.SetActive(false);
            slot_6.gameObject.SetActive(true);
            slot_7.gameObject.SetActive(false);
            slot_8.gameObject.SetActive(false);
            slot_9.gameObject.SetActive(false);
        }

        if (Input.GetKeyDown(KeyCode.Alpha7))
        {
            currentSlot = InventorySlots.Seven;
            inventorySlotText.text = "7";
            slot_0.gameObject.SetActive(false);
            slot_1.gameObject.SetActive(false);
            slot_2.gameObject.SetActive(false);
            slot_3.gameObject.SetActive(false);
            slot_4.gameObject.SetActive(false);
            slot_5.gameObject.SetActive(false);
            slot_6.gameObject.SetActive(false);
            slot_7.gameObject.SetActive(true);
            slot_8.gameObject.SetActive(false);
            slot_9.gameObject.SetActive(false);
        }

        if (Input.GetKeyDown(KeyCode.Alpha8))
        {
            currentSlot = InventorySlots.Eight;
            inventorySlotText.text = "8";
            slot_0.gameObject.SetActive(false);
            slot_1.gameObject.SetActive(false);
            slot_2.gameObject.SetActive(false);
            slot_3.gameObject.SetActive(false);
            slot_4.gameObject.SetActive(false);
            slot_5.gameObject.SetActive(false);
            slot_6.gameObject.SetActive(false);
            slot_7.gameObject.SetActive(false);
            slot_8.gameObject.SetActive(true);
            slot_9.gameObject.SetActive(false);
        }

        if (Input.GetKeyDown(KeyCode.Alpha9))
        {
            currentSlot = InventorySlots.Nine;
            inventorySlotText.text = "9";
            slot_0.gameObject.SetActive(false);
            slot_1.gameObject.SetActive(false);
            slot_2.gameObject.SetActive(false);
            slot_3.gameObject.SetActive(false);
            slot_4.gameObject.SetActive(false);
            slot_5.gameObject.SetActive(false);
            slot_6.gameObject.SetActive(false);
            slot_7.gameObject.SetActive(false);
            slot_8.gameObject.SetActive(false);
            slot_9.gameObject.SetActive(true);
        }
    }
}
