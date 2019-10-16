using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class PlayerStats : MonoBehaviour
{
    public int _lvl = 0;
    public float _hp = 100;
    private float _hpCheck;

    public Action<float> hpChange;
    public Action<ItemStats> AddItem;

    private ItemPickup _pickup;

    private void Start()
    {
        _pickup = GetComponent<ItemPickup>();
        _pickup.pickup += CheckItem;
        _hpCheck = _hp;
    }

    private void FixedUpdate()
    {
        // Implement with UI (if hp is going to play a signicant part in the game)
        //if(_hp != _hpCheck)
        //{
        //    if (hpChange != null) {
        //        hpChange(_hp);
        //        _hpCheck = _hp;
        //    } else
        //    {
        //        Debug.LogError("Couldn't send change in HP");
        //    }
        //}
    }

    private void CheckItem(ItemStats _item)
    {
        if(_item.lvl <= _lvl && _item.isUnlocked)
        {
            if(AddItem != null)
            {
                AddItem(_item);
            }
            else
            {
                Debug.LogError("Couldn't add item");
            }
        }
    }

}
