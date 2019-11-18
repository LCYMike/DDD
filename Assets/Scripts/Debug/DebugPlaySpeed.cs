using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DebugPlaySpeed : Tool
{
    public override void Run()
    {
        Debug.Log(Time.timeScale);
    }
}
