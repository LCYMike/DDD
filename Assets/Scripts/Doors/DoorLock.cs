using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class DoorLock : MonoBehaviour
{
    private Inventory _inv;

    public Action<ItemStats> openDoor;

    public TextMesh hintTxt;

    public Unlock unlockScript;

    private bool _isUnlocked = false;

    public string key = "key-name";

    private void Start()
    {
        hintTxt.text = "";
        _inv = FindObjectOfType<Inventory>();
    }


    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject.GetComponent<Inventory>() && !_isUnlocked)
        {
            var inv = collision.gameObject.GetComponent<Inventory>();

            if (inv.GetItem(new ItemStats(key)) != null){
                unlockScript.UnlockDoor();
                _isUnlocked = true;
            }
            else
            {
            hintTxt.text = "Door is locked\n Find the Key!";
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
