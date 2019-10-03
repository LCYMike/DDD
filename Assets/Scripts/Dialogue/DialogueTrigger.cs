using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueTrigger : MonoBehaviour
{

    public string[] texts;

    private float _range = 3f;

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
    }

    private void Update()
    {
        if (Vector3.Distance(transform.position, _player.transform.position) > _range)
        {
            _dialogue.abortDialogue();
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        _dialogue.displayText(texts);
        _rend.enabled = false;
        _col.enabled = false;
    }

    private void OnDrawGizmos()
    {
        Gizmos.color = Color.green;
        Gizmos.DrawWireSphere(transform.position, _range);
    }

}
