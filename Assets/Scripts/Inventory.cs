using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    #region Singleton

    public static Inventory instance;

    public void Awake()
    {
        if (instance != null)
        {
            Debug.LogWarning("More than one instance of Inventory found!");
            return;
        }

        instance = this;
    }

    #endregion

    public delegate void OnItemChanged();
    public OnItemChanged onItemChangedCallback;

    //inventory space
    public int space = 20;

    //list of items currently in inventory
    public List<Item> items = new List<Item>();

    //add-function
    public bool Add (Item item)
    {
        //if the inventory is full
        if (items.Count >= space)
        {
            Debug.Log("Not enough room.");
            return false;
        }

        //function to add new item to the inventory
        items.Add(item);

        if (onItemChangedCallback != null)
        {
            onItemChangedCallback.Invoke();
        }

        return true;
    }

    //function to remove item from the inventory
    public void Remove (Item item)
    {
        items.Remove(item);

        if (onItemChangedCallback != null)
        {
            onItemChangedCallback.Invoke();
        }
    }
}
