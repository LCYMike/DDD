using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class DoorLock : MonoBehaviour
{
    private Inventory _inv;

<<<<<<< HEAD:Assets/Scripts/Doors/DoorLock.cs
    public UnlockScript unlockScript;
=======
    public Action<ItemStats> openDoor;
>>>>>>> 4cbb339649c924a6e0fbf3e83eeb39c6357731e3:Assets/Scripts/Doors/DoorLock.cs

    public TextMesh hintTxt;

    public Unlock unlockScript;

    private bool _isUnlocked = false;

    public string key = "key-name";

    private void Start()
    {
        hintTxt.text = "";
        _inv = FindObjectOfType<Inventory>();
    }
<<<<<<< HEAD:Assets/Scripts/Doors/DoorLock.cs

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
            hintTxt.text = "Find the Main Gate Key";
        }
    }
=======
>>>>>>> 4cbb339649c924a6e0fbf3e83eeb39c6357731e3:Assets/Scripts/Doors/DoorLock.cs


    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject.GetComponent<Inventory>() && !_isUnlocked)
        {
<<<<<<< HEAD:Assets/Scripts/Doors/DoorLock.cs
            if(_inv != null)
            {
                Unlock(_inv.GetItem(new ItemStats(key)));
            } else
=======
            var inv = collision.gameObject.GetComponent<Inventory>();

            if (inv.GetItem(new ItemStats(key)) != null){
                unlockScript.UnlockDoor();
                _isUnlocked = true;
            }
            else
>>>>>>> 4cbb339649c924a6e0fbf3e83eeb39c6357731e3:Assets/Scripts/Doors/DoorLock.cs
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
