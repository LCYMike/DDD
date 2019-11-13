using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(AudioSource))]
public class PlaySound : TriggerEvent
{

    public AudioSource _aSrc;
    
    void Start()
    {
        if(_aSrc == null)
        {
            _aSrc = GetComponent<AudioSource>();   
        }
    }
    
    public override void Run()
    {
        _aSrc.Play();   
    }
}
