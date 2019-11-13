using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivateGameObject : TriggerEvent
{
    public GameObject[] objs;

    public override void Run()
    {
        if(objs == null)
        {
            Debug.LogError("Something went wrong, are there any entries?");
            return;
        }

        for (int i = 0; i < objs.Length; i++)
        {
            if(objs[i] != null)
            {
                objs[i].SetActive(true);
            }
            else
            {
                Debug.LogError("Something went wrong, are all entries filled?");
            }
        }
    }
}
