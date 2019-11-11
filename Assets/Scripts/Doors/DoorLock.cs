using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class DoorLock : MonoBehaviour
{
    private Inventory _inv;

    public UnlockScript unlockScript;

    public TextMesh hintTxt;

    private bool _isUnlocked = false;

    public string key = "key-name";
    public string txtValue = "Find Key";

    private void Start()
    {
        hintTxt.text = "";
        _inv = FindObjectOfType<Inventory>();
    }

    private void Unlock(ItemStats _item)
    {
        Debug.Log(_item);
        if (_item != null)
        {
            if(_item.name == key)
            {
                _isUnlocked = true;
                unlockScript.Unlock();
            }
        } else
        {
            hintTxt.text = txtValue;
        }
    }


    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject.GetComponent<Inventory>() && !_isUnlocked)
        {
            if(_inv != null)
            {
                Unlock(_inv.GetItem(new ItemStats(key)));
            } else
            {
                Debug.LogError("Couldn't send door key check");
            }

        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.GetComponent<Inventory>())
        {
            hintTxt.text = "";
        }
    }


}
