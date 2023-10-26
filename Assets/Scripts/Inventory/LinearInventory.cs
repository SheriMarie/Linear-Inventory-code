using System;
using System.Collections.Generic;
using UnityEngine;

public class LinearInventory : MonoBehaviour
{
    public List<Item> inventory = new List<Item>();
    public Item selectedItem;
    public bool showInv;
    public int money;
    public Vector2 scrollPos;
    public string sortType = "";
    public Vector3 dropLocation = Vector3.zero;

    [Serializable]
    public struct equipment
    {
        public string name;
        public Transform slotLocation;
        public GameObject currentEquippedItem;
    }

    public equipment[] equipmentSlots;

}
