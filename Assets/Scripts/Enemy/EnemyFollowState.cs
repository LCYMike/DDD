using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyFollowState : State
{
    private float _speed = 0.85f;
    private bool _goingLeft = true;
    private float _dir = -1f;

    private bool _canSeePlayer = true;

    private Transform _target;


    private void Awake()
    {
        _target = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
    }

    public void SetVisible(bool _visible)
    {
        _canSeePlayer = _visible;
    }

    public override void Run()
    {
        if (!_canSeePlayer)
        {
            SetDir();
        }

        transform.position += new Vector3(_dir * _speed * Time.deltaTime, 0f, 0f);
    }

    private void SetDir()
    {
        if(_target.transform.position.x < transform.position.x)
        {
            _goingLeft = true;
        }
        else
        {
            _goingLeft = false;
        }

        if (_goingLeft)
        {
            _dir = -1f;
        }
        else
        {
            _dir = 1;
        }
    }
}
