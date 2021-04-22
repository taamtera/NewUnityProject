using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Items : MonoBehaviour
{
    public enum ItemType
    {
        Sword,
        Shield,
        Wand,
        Potion,
    }

    public ItemType itemType;
    public int amount;
}
