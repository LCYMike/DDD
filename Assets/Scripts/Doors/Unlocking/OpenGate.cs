using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenGate : UnlockScript
{
    public GameObject leftDoor;
    public GameObject rightDoor;

    public override void Unlock()
    {
        StartCoroutine(DoorRotation());
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

}
