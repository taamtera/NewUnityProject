using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    List<Items> itemList;

    public Inventory()
    {
        itemList = new List<Items>();

        Debug.Log("Inventory");
    }
}
