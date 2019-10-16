using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class DialogueTrigger : MonoBehaviour
{

    public string[] texts;

    private float _range = 3f;

    public bool hasContinueBtn = true;
    public bool destroyOnFinish = false;
    private bool isActive = false;
    public Action finishDialogue;

    private GameObject _player;

    private MeshRenderer _rend;
    private BoxCollider _col;

    private SetDialogueTxt _dialogue;

    void Start()
    {
        _rend = GetComponent<MeshRenderer>();
        _col = GetComponent<BoxCollider>();
        _player = GameObject.FindGameObjectWithTag("Player");
        _dialogue = FindObjectOfType<SetDialogueTxt>();
        finishDialogue += DestroyTrigger;
    }

    private void Update()
    {
        if (Vector3.Distance(transform.position, _player.transform.position) > _range)
        {
            isActive = false;
            _dialogue.abortDialogue();
        }
    }

    public void DestroyTrigger()
    {
        if(isActive && destroyOnFinish)
        {
            Destroy(gameObject);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        _dialogue.displayText(texts, hasContinueBtn);
        isActive = true;
        _rend.enabled = false;
        _col.enabled = false;
    }

    private void OnDrawGizmos()
    {
        Gizmos.color = Color.green;
        Gizmos.DrawWireSphere(transform.position, _range);
    }

}
