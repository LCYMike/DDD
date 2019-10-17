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

    public TextMesh hintTxt;

    private bool _isUnlocked = false;

    public string key = "key-name";

    private void Start()
    {
        hintTxt.text = "";
        _inv = FindObjectOfType<Inventory>();
    }
    

    IEnumerator DoorRotation()
    {
            for (int i = 0; i < 90; i++)
            {
                leftDoor.gameObject.transform.Rotate(new Vector3(0f, 1f, 0f));
                rightDoor.gameObject.transform.Rotate(new Vector3(0f, -1f, 0f));
                yield return new WaitForSeconds(2 / 90);
            }
    }


    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject.GetComponent<Inventory>() && !_isUnlocked)
        {
            var inv = collision.gameObject.GetComponent<Inventory>();

            if (inv.GetItem(new ItemStats(key)) != null){
                StartCoroutine(DoorRotation());
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
