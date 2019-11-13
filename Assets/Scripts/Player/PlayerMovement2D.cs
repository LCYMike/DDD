using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class PlayerMovement2D : MonoBehaviour {
    
    private Transform _trans;
    [SerializeField]
    private float _speed = 1;
    private bool _freeze = false;

    public Action<float> playerDir;
    private SetDialogueTxt _dialogue;

	void Start () {
        _dialogue = FindObjectOfType<SetDialogueTxt>();
        _dialogue.isActive += SetCanMove;
       _trans = GetComponent<Transform>();
    }
	
    private void SetCanMove(bool _freezeEntity)
    {
        _freeze = _freezeEntity;
    }

	void FixedUpdate () {
        float direction = Input.GetAxisRaw("Horizontal");
		if(direction != 0 && !_freeze)
        {
            _trans.position += new Vector3(direction * _speed * Time.deltaTime, 0f, 0f);
            if(playerDir != null)
            {
                playerDir(direction);
            }
        }
	}
}
