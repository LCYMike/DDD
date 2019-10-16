using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class DoorLock : MonoBehaviour
{
    private Inventory _inv;

    public Action<ItemStats> openDoor;

    public GameObject leftDoor;
    public GameObject rightDoor;

    public string key = "key-name";

    private void Start()
    {
        _inv = FindObjectOfType<Inventory>();
        _inv.unlockDoor += Unlock;
    }

    private void Unlock(ItemStats _item)
    {
        if(key == _item.name)
        {
            for (int i = 0; i < 90; i++)
            {
                //leftDoor.gameObject.transform.rotation;
            }
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.GetComponent<Inventory>())
        {
            if(openDoor != null)
            {
                openDoor(new ItemStats(key));
            } else
            {
                Debug.LogError("Couldn't send door key check");
            }

        }
    }

}
