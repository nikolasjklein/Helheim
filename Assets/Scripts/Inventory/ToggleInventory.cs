using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ToggleInventory : MonoBehaviour
{
    public Canvas inventoryCanvas;

    public bool isToggled = true;

    public InventoryUI inventoryUI;

    public void Start()
    {
        isToggled = true;
    }

    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.I))
        {
            if (isToggled)
            {
                isToggled = false;
                Time.timeScale = 1;
                Cursor.visible = false;
                Cursor.lockState = CursorLockMode.Locked;
            }

            else if (!isToggled)
            {
                isToggled = true;
                Time.timeScale = 0;
                Cursor.visible = true;
                Cursor.lockState = CursorLockMode.None;
            }
        }

        if (isToggled)
        {
            inventoryCanvas.gameObject.SetActive(true);
        }

        else if (!isToggled)
        {
            inventoryCanvas.gameObject.SetActive(false);
            inventoryUI.Scroll_Armor_Triggered = false;
            inventoryUI.Scroll_Weapon_Triggered = false;
        }
    }
}
