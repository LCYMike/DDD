using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GateUnlock : Unlock
{
    public GameObject leftDoor;
    public GameObject rightDoor;

    public override void UnlockDoor()
    {
        StartCoroutine(DoorRotation());
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
}
