using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class ItemPickup : MonoBehaviour {

    public Action<ItemStats> pickup;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.GetComponent<Item>())
        {
            var _item = collision.gameObject.GetComponent<Item>().stats;

            if (_item != null)
            {
                pickup(_item);
            } else
                Debug.LogError("Couldn't send item data");            }
            {
        }   
    }
}
