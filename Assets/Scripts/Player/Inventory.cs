using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Inventory : MonoBehaviour
{

    private PlayerStats _playerStats;

    [SerializeField]
    private List<ItemStats> _items;

    ItemStats item;

    private void Start()
    {
        _playerStats = FindObjectOfType<PlayerStats>();
        _playerStats.AddItem += AddItem;

    }

    public ItemStats GetItem(ItemStats _item)
    {
        for (int i = 0; i < _items.Count; i++)
        {
            if(_items[i].name == _item.name)
            {
                return _items[i];
            }
        }
        return null;
    }

    public void AddItem(ItemStats _item)
    {
        item = _item;
        _items.Add(_item);
    }

    public void RemoveItem(ItemStats _item)
    {
        item = _item;
        _items.Remove(_item);
    }


}
