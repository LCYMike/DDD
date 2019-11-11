using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class DialogueTrigger : MonoBehaviour
{

    public string[] texts;
    public bool hasContinueBtn = true;

    private SetDialogueTxt _dialogue;

    void Start()
    {
        _dialogue = FindObjectOfType<SetDialogueTxt>();
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            _dialogue.SetDialogue(texts, hasContinueBtn);
            Destroy(gameObject);
        }
    }
}
