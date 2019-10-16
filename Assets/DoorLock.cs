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
            StartCoroutine(DoorRotation());
        }
    }

    IEnumerator DoorRotation()
    {
            for (int i = 0; i < 90; i++)
            {
                leftDoor.gameObject.transform.Rotate(new Vector3(leftDoor.gameObject.transform.rotation.x, leftDoor.gameObject.transform.rotation.y + 0.8f, leftDoor.gameObject.transform.rotation.z));
                rightDoor.gameObject.transform.Rotate(new Vector3(rightDoor.gameObject.transform.rotation.x, rightDoor.gameObject.transform.rotation.y - 0.8f, rightDoor.gameObject.transform.rotation.z));
                yield return new WaitForSeconds(2 / 90);
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
