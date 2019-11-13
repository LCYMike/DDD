using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(DialogueTriggerEvent))]
public class TriggerEvent : MonoBehaviour
{
    public virtual void Run() { }
}
