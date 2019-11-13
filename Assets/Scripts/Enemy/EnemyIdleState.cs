using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyIdleState : State
{

    public Vector2 _xZone = new Vector2(-5f, 5f);
    private float _speed = 0.85f;
    private bool _goingLeft = true;
    private bool _inZone = true;
    private float _dir;


    public override void Run()
    {
        CheckZone();
        SetDir();

        transform.position += new Vector3(_dir * _speed * Time.deltaTime, 0f, 0f);
    }

    private void SetDir()
    {
        if (_goingLeft)
        {
            _dir = -1f;
        }
        else
        {
            _dir = 1;
        }
    }

    private void CheckZone()
    {
        float _pos = transform.position.x;
        if (_pos > _xZone.y)
        {
            _inZone = true;
            _goingLeft = true;
        }
        else if (_pos < _xZone.x)
        {
            _inZone = false;
            _goingLeft = false;
        }
        else
        {
            _inZone = true;
        }
    }

}
