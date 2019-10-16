using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Inventory : MonoBehaviour
{

    private PlayerStats _playerStats;
    private DoorLock[] _gates;

    [SerializeField]
    private List<ItemStats> _items;

    public Action<ItemStats> unlockDoor;

    ItemStats item;

    private void Start()
    {
        _playerStats = FindObjectOfType<PlayerStats>();
        _playerStats.AddItem += AddItem;
        _gates = FindObjectsOfType<DoorLock>();
        for (int i = 0; i < _gates.Length; i++)
        {
            _gates[i].openDoor += CheckKey;
        }
    }

    private void CheckKey(ItemStats _item)
    {
        for (int i = 0; i < _items.Count; i++)
        {
            if(_items[i].name == _item.name)
            {
                if(unlockDoor != null)
                {
                    unlockDoor(_items[i]);
                }else
                {
                    Debug.LogError("Couldn't unlock door");
                }
            }
        }
    }

    private void AddItem(ItemStats _item)
    {
        item = _item;
        _items.Add(_item);
    }

}
