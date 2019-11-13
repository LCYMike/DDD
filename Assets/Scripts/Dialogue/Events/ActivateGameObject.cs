using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivateGameObject : TriggerEvent
{
    public GameObject obj;

    public override void Run()
    {
        obj.SetActive(true);
    }
}
