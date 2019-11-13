using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class DialogueTriggerEvent : MonoBehaviour
{

    public string[] texts;
    public bool hasContinueBtn = true;

    public TriggerEvent[] actions;
    private bool hasEvent = false;

    private SetDialogueTxt _dialogue;

    void Start()
    {
        _dialogue = FindObjectOfType<SetDialogueTxt>();
        if(actions != null)
        {
            hasEvent = true;
            for (int i = 0; i < actions.Length; i++)
            {
                if(actions[i] == null)
                {
                    hasEvent = false;
                    Debug.LogError("Somethings not right with the actions list, are all the open slots filled?");
                }
            }
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            _dialogue.SetDialogue(texts, hasContinueBtn);

            if (hasEvent)
            {
                for (int i = 0; i < actions.Length; i++)
                {
                    actions[i].Run();
                }
            }
            gameObject.GetComponent<Collider2D>().enabled = false;
        }
    }
}
