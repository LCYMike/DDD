using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class PlayerMovement2D : MonoBehaviour {
    
    private Transform _trans;
    [SerializeField]
    private float _speed = 1;

    public Action<float> playerDir;

	void Start () {
       _trans = GetComponent<Transform>();
    }
	
	void FixedUpdate () {
        float direction = Input.GetAxisRaw("Horizontal");
		if(direction != 0)
        {
            _trans.position += new Vector3(direction * _speed * Time.deltaTime, 0f, 0f);
            if(playerDir != null)
            {
                playerDir(direction);
            }
        }
	}
}
