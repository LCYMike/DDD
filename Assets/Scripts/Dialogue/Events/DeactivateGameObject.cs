using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeactivateGameObject : TriggerEvent
{
    public GameObject obj;

    public override void Run()
    {
        obj.SetActive(false);
    }
}
