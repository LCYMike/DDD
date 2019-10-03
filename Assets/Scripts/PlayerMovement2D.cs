using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement2D : MonoBehaviour {
    
    private Transform _trans;
    [SerializeField]
    private float _speed = 1;

	void Start () {
       _trans = GetComponent<Transform>();
    }
	
	void FixedUpdate () {
        float direction = Input.GetAxisRaw("Horizontal");
		if(direction != 0)
        {
            _trans.position += new Vector3(direction * _speed * Time.deltaTime, 0f, 0f);
        }
	}
}
